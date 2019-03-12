#! /usr/bin/env awk
#
# Create reference tags and WIN32 initialization functions for tags.
#
# --------------------------------------------------------------------
#
# This file is part of the Sofia-SIP package
#
# Copyright (C) 2005 Nokia Corporation.
#
# Contact: Pekka Pessi <pekka.pessi@nokia.com>
#
# This library is free software; you can redistribute it and/or
# modify it under the terms of the GNU Lesser General Public License
# as published by the Free Software Foundation; either version 2.1 of
# the License, or (at your option) any later version.
#
# This library is distributed in the hope that it will be useful, but
# WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
# Lesser General Public License for more details.
#
# You should have received a copy of the GNU Lesser General Public
# License along with this library; if not, write to the Free Software
# Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
# 02110-1301 USA
#
# --------------------------------------------------------------------
#
# Author: Pekka Pessi <Pekka.Pessi@nokia.com>
#
# Created: Tue Feb 26 14:11:25 2002 ppessi
#

BEGIN {
  DEFS = 0;
  HEADER = 1;
}

HEADER {
  HEADER = 0;

  if (OUTNAME != "") {
    fn = OUTNAME;
  } else {
    fn = FILENAME;
  }

  if (REF == "") {
    REF = fn;
    sub(/[.]c(at)?/, "_ref.c", REF);
  }

  if (NODLL) DLL = "/dev/null";

  if (DLL == "") {
    DLL = fn;
    sub(/[.]c(at)?/, "_dll.c", DLL);
  }

  base = fn;
  sub(/.*\//, "", base);

  printf("#ifdef _WIN32\n"\
	 "/*\n" \
	 " * PLEASE NOTE: \n" \
	 " * \n" \
	 " * This file is automatically generated by tag_dll.awk.\n"\
	 " * It contains magic required by Win32 DLLs to initialize\n"\
	 " * tag_typedef_t variables.\n"\
	 " * \n"\
	 " * Do not, repeat, do not edit this file. Edit '%s' instead.\n"\
	 " * \n"\
	 " */\n\n"\
	 "#define EXPORT __declspec(dllexport)\n\n", base) > DLL;

  if (DLLREF) {
    print \
      "#include \"config.h\"\n\n" \
      "#include <sofia-sip/su_tag_class.h>\n\n" > DLL;
  }

  printf("/*\n" \
	 " * PLEASE NOTE: \n" \
	 " * \n" \
	 " * This file is automatically generated by tag_dll.awk.\n"\
	 " * It contains tag_typedef_t for tag references.\n"\
	 " * \n"\
	 " * Do not, repeat, do not edit this file. Edit '%s' instead.\n"\
	 " * \n"\
	 " */\n\n"\
	 "#include \"config.h\"\n\n"\
	 "#include <sofia-sip/su_tag_class.h>\n"\
	 "\n"\
	 "#if defined _WIN32 || defined HAVE_OPEN_C\n"\
	 "#define EXPORT __declspec(dllexport)\n"\
	 "#else\n"\
	 "#define EXPORT\n"\
	 "#endif\n\n",
	 base) > REF;

  if (LIST) {
    print "#include <stddef.h>" >REF;
  }
  print "" > REF;
}

/^#define TAG_NAMESPACE/ {
  print "#undef TAG_NAMESPACE" > REF;
  print $0 > REF;
  print "" > REF;
  print "#undef TAG_NAMESPACE" > DLL;
  print $0 > DLL;
  print "" > DLL;
}

/SU_HAVE_EXPERIMENTAL/ {
  print $0 > REF;
  print $0 > DLL;
}

!DEFS && /^tag_typedef_t/ { DEFS = 1; }

DEFS && /tag_typedef_t/ {
  tag = $2;
  typedefs[tag] = $0;

  if ($0 !~ /NSTAG_TYPEDEF/) {
    print "extern tag_typedef_t "tag";" > REF;
    print "EXPORT tag_typedef_t "tag"_ref;" > DLL;
    print "EXPORT tag_typedef_t "tag"_ref = \n  REFTAG_TYPEDEF("tag");" > REF;
  }

  gsub(/ = .*$/, ";");
}

!DLLREF { print $0 > DLL; }

END {
  if (LIST) {
    print "\nEXPORT tag_type_t " LIST "[] =\n{" > REF;
    print "\nEXPORT tag_type_t " LIST "[] =\n{" > DLL;
    for (tag in typedefs) {
      if (typedefs[tag] !~ /NSTAG_TYPEDEF/) {
        print "  " tag "," > REF;
        print "  " tag "," > DLL;
      }
    }
    print "  NULL\n};" > REF;
    print "  NULL\n};" > DLL;
  }

  printf("\n" \
	 "#include <windows.h>\n"\
	 "\n"\
	 "BOOL WINAPI DllMain(HINSTANCE hInst, DWORD fwdReason, LPVOID fImpLoad)\n"\
	 "{\n") > DLL;

   for (tag in typedefs) {
     def = typedefs[tag];
     if (!DLLREF) {
       sub(/^tag_typedef_t /, "  tag_typedef_t _", def);
       print def > DLL;
     }
     else {
       print "  extern tag_typedef_t "tag";" > DLL;
     }
     print "  tag_typedef_t _"tag"_ref =\n    REFTAG_TYPEDEF("tag");" > DLL;
   }

   print "" > DLL;

   for (tag in typedefs) {
     if (!DLLREF) {
       print "  *(struct tag_type_s *)" tag " = *_" tag ";" > DLL;
     }
     print "  *(struct tag_type_s *)" tag "_ref = *_" tag "_ref;" > DLL;
   }

   print "\n  return TRUE;" > DLL;
   print "}" > DLL;
   print "\n#endif" > DLL;
}
