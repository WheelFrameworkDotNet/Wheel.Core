@ECHO off
title Generador de documentacion

SET nombreProyecto=%1
IF "%1" == "" (SET /p nombreProyecto=Nombre del proyecto: )

ECHO.
ECHO		-=========================================================-
ECHO 	* Nombre del Proyecto: %nombreProyecto%
ECHO 	-=========================================================-
ECHO.

:GenerarArchivoDocumentacion
ECHO [%DATE% %TIME%] Generando archivo de configuracion...
ECHO # Doxyfile 1.8.11 > Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Project related configuration options >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO DOXYFILE_ENCODING      = UTF-8 >> Doc.Config
ECHO PROJECT_NAME           = %nombreProyecto% >> Doc.Config
ECHO PROJECT_NUMBER         =  >> Doc.Config
ECHO PROJECT_BRIEF          =  >> Doc.Config
ECHO PROJECT_LOGO           = C:/WheelFramework/__Resources__/Logo/Logo_Small.png >> Doc.Config
ECHO OUTPUT_DIRECTORY       = ./docs >> Doc.Config
ECHO CREATE_SUBDIRS         = NO >> Doc.Config
ECHO ALLOW_UNICODE_NAMES    = NO >> Doc.Config
ECHO OUTPUT_LANGUAGE        = Spanish >> Doc.Config
ECHO BRIEF_MEMBER_DESC      = YES >> Doc.Config
ECHO REPEAT_BRIEF           = YES >> Doc.Config
ECHO ABBREVIATE_BRIEF       = "The $name class" \ >> Doc.Config
ECHO                          "The $name widget" \ >> Doc.Config
ECHO                          "The $name file" \ >> Doc.Config
ECHO                          is \ >> Doc.Config
ECHO                          provides \ >> Doc.Config
ECHO                          specifies \ >> Doc.Config
ECHO                          contains \ >> Doc.Config
ECHO                          represents \ >> Doc.Config
ECHO                          a \ >> Doc.Config
ECHO                          an \ >> Doc.Config
ECHO                          the >> Doc.Config
ECHO ALWAYS_DETAILED_SEC    = NO >> Doc.Config
ECHO INLINE_INHERITED_MEMB  = NO >> Doc.Config
ECHO FULL_PATH_NAMES        = YES >> Doc.Config
ECHO STRIP_FROM_PATH        =  >> Doc.Config
ECHO STRIP_FROM_INC_PATH    =  >> Doc.Config
ECHO SHORT_NAMES            = NO >> Doc.Config
ECHO JAVADOC_AUTOBRIEF      = NO >> Doc.Config
ECHO QT_AUTOBRIEF           = NO >> Doc.Config
ECHO MULTILINE_CPP_IS_BRIEF = NO >> Doc.Config
ECHO INHERIT_DOCS           = YES >> Doc.Config
ECHO SEPARATE_MEMBER_PAGES  = NO >> Doc.Config
ECHO TAB_SIZE               = 4 >> Doc.Config
ECHO ALIASES                =  >> Doc.Config
ECHO TCL_SUBST              =  >> Doc.Config
ECHO OPTIMIZE_OUTPUT_FOR_C  = NO >> Doc.Config
ECHO OPTIMIZE_OUTPUT_JAVA   = NO >> Doc.Config
ECHO OPTIMIZE_FOR_FORTRAN   = NO >> Doc.Config
ECHO OPTIMIZE_OUTPUT_VHDL   = NO >> Doc.Config
ECHO EXTENSION_MAPPING      =  >> Doc.Config
ECHO MARKDOWN_SUPPORT       = YES >> Doc.Config
ECHO AUTOLINK_SUPPORT       = YES >> Doc.Config
ECHO BUILTIN_STL_SUPPORT    = NO >> Doc.Config
ECHO CPP_CLI_SUPPORT        = NO >> Doc.Config
ECHO SIP_SUPPORT            = NO >> Doc.Config
ECHO IDL_PROPERTY_SUPPORT   = YES >> Doc.Config
ECHO DISTRIBUTE_GROUP_DOC   = NO >> Doc.Config
ECHO GROUP_NESTED_COMPOUNDS = NO >> Doc.Config
ECHO SUBGROUPING            = YES >> Doc.Config
ECHO INLINE_GROUPED_CLASSES = NO >> Doc.Config
ECHO INLINE_SIMPLE_STRUCTS  = NO >> Doc.Config
ECHO TYPEDEF_HIDES_STRUCT   = NO >> Doc.Config
ECHO LOOKUP_CACHE_SIZE      = 0 >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Build related configuration options >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO EXTRACT_ALL            = NO >> Doc.Config
ECHO EXTRACT_PRIVATE        = NO >> Doc.Config
ECHO EXTRACT_PACKAGE        = NO >> Doc.Config
ECHO EXTRACT_STATIC         = NO >> Doc.Config
ECHO EXTRACT_LOCAL_CLASSES  = YES >> Doc.Config
ECHO EXTRACT_LOCAL_METHODS  = NO >> Doc.Config
ECHO EXTRACT_ANON_NSPACES   = NO >> Doc.Config
ECHO HIDE_UNDOC_MEMBERS     = NO >> Doc.Config
ECHO HIDE_UNDOC_CLASSES     = NO >> Doc.Config
ECHO HIDE_FRIEND_COMPOUNDS  = NO >> Doc.Config
ECHO HIDE_IN_BODY_DOCS      = NO >> Doc.Config
ECHO INTERNAL_DOCS          = NO >> Doc.Config
ECHO CASE_SENSE_NAMES       = NO >> Doc.Config
ECHO HIDE_SCOPE_NAMES       = NO >> Doc.Config
ECHO HIDE_COMPOUND_REFERENCE= NO >> Doc.Config
ECHO SHOW_INCLUDE_FILES     = YES >> Doc.Config
ECHO SHOW_GROUPED_MEMB_INC  = NO >> Doc.Config
ECHO FORCE_LOCAL_INCLUDES   = NO >> Doc.Config
ECHO INLINE_INFO            = YES >> Doc.Config
ECHO SORT_MEMBER_DOCS       = YES >> Doc.Config
ECHO SORT_BRIEF_DOCS        = NO >> Doc.Config
ECHO SORT_MEMBERS_CTORS_1ST = NO >> Doc.Config
ECHO SORT_GROUP_NAMES       = NO >> Doc.Config
ECHO SORT_BY_SCOPE_NAME     = NO >> Doc.Config
ECHO STRICT_PROTO_MATCHING  = NO >> Doc.Config
ECHO GENERATE_TODOLIST      = YES >> Doc.Config
ECHO GENERATE_TESTLIST      = YES >> Doc.Config
ECHO GENERATE_BUGLIST       = YES >> Doc.Config
ECHO GENERATE_DEPRECATEDLIST= YES >> Doc.Config
ECHO ENABLED_SECTIONS       =  >> Doc.Config
ECHO MAX_INITIALIZER_LINES  = 30 >> Doc.Config
ECHO SHOW_USED_FILES        = YES >> Doc.Config
ECHO SHOW_FILES             = YES >> Doc.Config
ECHO SHOW_NAMESPACES        = YES >> Doc.Config
ECHO FILE_VERSION_FILTER    =  >> Doc.Config
ECHO LAYOUT_FILE            =  >> Doc.Config
ECHO CITE_BIB_FILES         =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to warning and progress messages >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO QUIET                  = NO >> Doc.Config
ECHO WARNINGS               = YES >> Doc.Config
ECHO WARN_IF_UNDOCUMENTED   = YES >> Doc.Config
ECHO WARN_IF_DOC_ERROR      = YES >> Doc.Config
ECHO WARN_NO_PARAMDOC       = NO >> Doc.Config
ECHO WARN_AS_ERROR          = NO >> Doc.Config
ECHO WARN_FORMAT            = "$file:$line: $text" >> Doc.Config
ECHO WARN_LOGFILE           =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the input files >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO INPUT                  = ./src >> Doc.Config
ECHO INPUT_ENCODING         = UTF-8 >> Doc.Config
ECHO FILE_PATTERNS          = *.c \ >> Doc.Config
ECHO                          *.cc \ >> Doc.Config
ECHO                          *.cxx \ >> Doc.Config
ECHO                          *.cpp \ >> Doc.Config
ECHO                          *.c++ \ >> Doc.Config
ECHO                          *.java \ >> Doc.Config
ECHO                          *.ii \ >> Doc.Config
ECHO                          *.ixx \ >> Doc.Config
ECHO                          *.ipp \ >> Doc.Config
ECHO                          *.i++ \ >> Doc.Config
ECHO                          *.inl \ >> Doc.Config
ECHO                          *.idl \ >> Doc.Config
ECHO                          *.ddl \ >> Doc.Config
ECHO                          *.odl \ >> Doc.Config
ECHO                          *.h \ >> Doc.Config
ECHO                          *.hh \ >> Doc.Config
ECHO                          *.hxx \ >> Doc.Config
ECHO                          *.hpp \ >> Doc.Config
ECHO                          *.h++ \ >> Doc.Config
ECHO                          *.cs \ >> Doc.Config
ECHO                          *.d \ >> Doc.Config
ECHO                          *.php \ >> Doc.Config
ECHO                          *.php4 \ >> Doc.Config
ECHO                          *.php5 \ >> Doc.Config
ECHO                          *.phtml \ >> Doc.Config
ECHO                          *.inc \ >> Doc.Config
ECHO                          *.m \ >> Doc.Config
ECHO                          *.markdown \ >> Doc.Config
ECHO                          *.md \ >> Doc.Config
ECHO                          *.mm \ >> Doc.Config
ECHO                          *.dox \ >> Doc.Config
ECHO                          *.py \ >> Doc.Config
ECHO                          *.pyw \ >> Doc.Config
ECHO                          *.f90 \ >> Doc.Config
ECHO                          *.f \ >> Doc.Config
ECHO                          *.for \ >> Doc.Config
ECHO                          *.tcl \ >> Doc.Config
ECHO                          *.vhd \ >> Doc.Config
ECHO                          *.vhdl \ >> Doc.Config
ECHO                          *.ucf \ >> Doc.Config
ECHO                          *.qsf \ >> Doc.Config
ECHO                          *.as \ >> Doc.Config
ECHO                          *.js >> Doc.Config
ECHO RECURSIVE              = YES >> Doc.Config
ECHO EXCLUDE                =  >> Doc.Config
ECHO EXCLUDE_SYMLINKS       = NO >> Doc.Config
ECHO EXCLUDE_PATTERNS       =  >> Doc.Config
ECHO EXCLUDE_SYMBOLS        =  >> Doc.Config
ECHO EXAMPLE_PATH           =  >> Doc.Config
ECHO EXAMPLE_PATTERNS       = * >> Doc.Config
ECHO EXAMPLE_RECURSIVE      = NO >> Doc.Config
ECHO IMAGE_PATH             =  >> Doc.Config
ECHO INPUT_FILTER           =  >> Doc.Config
ECHO FILTER_PATTERNS        =  >> Doc.Config
ECHO FILTER_SOURCE_FILES    = NO >> Doc.Config
ECHO FILTER_SOURCE_PATTERNS =  >> Doc.Config
ECHO USE_MDFILE_AS_MAINPAGE =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to source browsing >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO SOURCE_BROWSER         = NO >> Doc.Config
ECHO INLINE_SOURCES         = NO >> Doc.Config
ECHO STRIP_CODE_COMMENTS    = YES >> Doc.Config
ECHO REFERENCED_BY_RELATION = NO >> Doc.Config
ECHO REFERENCES_RELATION    = NO >> Doc.Config
ECHO REFERENCES_LINK_SOURCE = YES >> Doc.Config
ECHO SOURCE_TOOLTIPS        = YES >> Doc.Config
ECHO USE_HTAGS              = NO >> Doc.Config
ECHO VERBATIM_HEADERS       = YES >> Doc.Config
ECHO CLANG_ASSISTED_PARSING = NO >> Doc.Config
ECHO CLANG_OPTIONS          =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the alphabetical class index >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO ALPHABETICAL_INDEX     = YES >> Doc.Config
ECHO COLS_IN_ALPHA_INDEX    = 5 >> Doc.Config
ECHO IGNORE_PREFIX          =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the HTML output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_HTML          = YES >> Doc.Config
ECHO HTML_OUTPUT            = ./code >> Doc.Config
ECHO HTML_FILE_EXTENSION    = .html >> Doc.Config
ECHO HTML_HEADER            =  >> Doc.Config
ECHO HTML_FOOTER            =  >> Doc.Config
ECHO HTML_STYLESHEET        =  >> Doc.Config
ECHO HTML_EXTRA_STYLESHEET  =  >> Doc.Config
ECHO HTML_EXTRA_FILES       =  >> Doc.Config
ECHO HTML_COLORSTYLE_HUE    = 220 >> Doc.Config
ECHO HTML_COLORSTYLE_SAT    = 100 >> Doc.Config
ECHO HTML_COLORSTYLE_GAMMA  = 80 >> Doc.Config
ECHO HTML_TIMESTAMP         = NO >> Doc.Config
ECHO HTML_DYNAMIC_SECTIONS  = NO >> Doc.Config
ECHO HTML_INDEX_NUM_ENTRIES = 100 >> Doc.Config
ECHO GENERATE_DOCSET        = NO >> Doc.Config
ECHO DOCSET_FEEDNAME        = "Doxygen generated docs" >> Doc.Config
ECHO DOCSET_BUNDLE_ID       = org.doxygen.Project >> Doc.Config
ECHO DOCSET_PUBLISHER_ID    = org.doxygen.Publisher >> Doc.Config
ECHO DOCSET_PUBLISHER_NAME  = Publisher >> Doc.Config
ECHO GENERATE_HTMLHELP      = NO >> Doc.Config
ECHO CHM_FILE               =  >> Doc.Config
ECHO HHC_LOCATION           =  >> Doc.Config
ECHO GENERATE_CHI           = NO >> Doc.Config
ECHO CHM_INDEX_ENCODING     =  >> Doc.Config
ECHO BINARY_TOC             = NO >> Doc.Config
ECHO TOC_EXPAND             = NO >> Doc.Config
ECHO GENERATE_QHP           = NO >> Doc.Config
ECHO QCH_FILE               =  >> Doc.Config
ECHO QHP_NAMESPACE          = org.doxygen.Project >> Doc.Config
ECHO QHP_VIRTUAL_FOLDER     = doc >> Doc.Config
ECHO QHP_CUST_FILTER_NAME   =  >> Doc.Config
ECHO QHP_CUST_FILTER_ATTRS  =  >> Doc.Config
ECHO QHP_SECT_FILTER_ATTRS  =  >> Doc.Config
ECHO QHG_LOCATION           =  >> Doc.Config
ECHO GENERATE_ECLIPSEHELP   = NO >> Doc.Config
ECHO ECLIPSE_DOC_ID         = org.doxygen.Project >> Doc.Config
ECHO DISABLE_INDEX          = NO >> Doc.Config
ECHO GENERATE_TREEVIEW      = NO >> Doc.Config
ECHO ENUM_VALUES_PER_LINE   = 4 >> Doc.Config
ECHO TREEVIEW_WIDTH         = 250 >> Doc.Config
ECHO EXT_LINKS_IN_WINDOW    = NO >> Doc.Config
ECHO FORMULA_FONTSIZE       = 10 >> Doc.Config
ECHO FORMULA_TRANSPARENT    = YES >> Doc.Config
ECHO USE_MATHJAX            = NO >> Doc.Config
ECHO MATHJAX_FORMAT         = HTML-CSS >> Doc.Config
ECHO MATHJAX_RELPATH        = http://cdn.mathjax.org/mathjax/latest >> Doc.Config
ECHO MATHJAX_EXTENSIONS     =  >> Doc.Config
ECHO MATHJAX_CODEFILE       =  >> Doc.Config
ECHO SEARCHENGINE           = YES >> Doc.Config
ECHO SERVER_BASED_SEARCH    = NO >> Doc.Config
ECHO EXTERNAL_SEARCH        = NO >> Doc.Config
ECHO SEARCHENGINE_URL       =  >> Doc.Config
ECHO SEARCHDATA_FILE        = searchdata.xml >> Doc.Config
ECHO EXTERNAL_SEARCH_ID     =  >> Doc.Config
ECHO EXTRA_SEARCH_MAPPINGS  =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the LaTeX output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_LATEX         = NO >> Doc.Config
ECHO LATEX_OUTPUT           = latex >> Doc.Config
ECHO LATEX_CMD_NAME         = latex >> Doc.Config
ECHO MAKEINDEX_CMD_NAME     = makeindex >> Doc.Config
ECHO COMPACT_LATEX          = NO >> Doc.Config
ECHO PAPER_TYPE             = a4 >> Doc.Config
ECHO EXTRA_PACKAGES         =  >> Doc.Config
ECHO LATEX_HEADER           =  >> Doc.Config
ECHO LATEX_FOOTER           =  >> Doc.Config
ECHO LATEX_EXTRA_STYLESHEET =  >> Doc.Config
ECHO LATEX_EXTRA_FILES      =  >> Doc.Config
ECHO PDF_HYPERLINKS         = YES >> Doc.Config
ECHO USE_PDFLATEX           = YES >> Doc.Config
ECHO LATEX_BATCHMODE        = NO >> Doc.Config
ECHO LATEX_HIDE_INDICES     = NO >> Doc.Config
ECHO LATEX_SOURCE_CODE      = NO >> Doc.Config
ECHO LATEX_BIB_STYLE        = plain >> Doc.Config
ECHO LATEX_TIMESTAMP        = NO >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the RTF output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_RTF           = NO >> Doc.Config
ECHO RTF_OUTPUT             = rtf >> Doc.Config
ECHO COMPACT_RTF            = NO >> Doc.Config
ECHO RTF_HYPERLINKS         = NO >> Doc.Config
ECHO RTF_STYLESHEET_FILE    =  >> Doc.Config
ECHO RTF_EXTENSIONS_FILE    =  >> Doc.Config
ECHO RTF_SOURCE_CODE        = NO >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the man page output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_MAN           = NO >> Doc.Config
ECHO MAN_OUTPUT             = man >> Doc.Config
ECHO MAN_EXTENSION          = .3 >> Doc.Config
ECHO MAN_SUBDIR             =  >> Doc.Config
ECHO MAN_LINKS              = NO >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the XML output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_XML           = NO >> Doc.Config
ECHO XML_OUTPUT             = xml >> Doc.Config
ECHO XML_PROGRAMLISTING     = YES >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the DOCBOOK output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_DOCBOOK       = NO >> Doc.Config
ECHO DOCBOOK_OUTPUT         = docbook >> Doc.Config
ECHO DOCBOOK_PROGRAMLISTING = NO >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options for the AutoGen Definitions output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_AUTOGEN_DEF   = NO >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the Perl module output >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO GENERATE_PERLMOD       = NO >> Doc.Config
ECHO PERLMOD_LATEX          = NO >> Doc.Config
ECHO PERLMOD_PRETTY         = YES >> Doc.Config
ECHO PERLMOD_MAKEVAR_PREFIX =  >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the preprocessor >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO ENABLE_PREPROCESSING   = YES >> Doc.Config
ECHO MACRO_EXPANSION        = NO >> Doc.Config
ECHO EXPAND_ONLY_PREDEF     = NO >> Doc.Config
ECHO SEARCH_INCLUDES        = YES >> Doc.Config
ECHO INCLUDE_PATH           =  >> Doc.Config
ECHO INCLUDE_FILE_PATTERNS  =  >> Doc.Config
ECHO PREDEFINED             =  >> Doc.Config
ECHO EXPAND_AS_DEFINED      =  >> Doc.Config
ECHO SKIP_FUNCTION_MACROS   = YES >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to external references >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO TAGFILES               =  >> Doc.Config
ECHO GENERATE_TAGFILE       =  >> Doc.Config
ECHO ALLEXTERNALS           = NO >> Doc.Config
ECHO EXTERNAL_GROUPS        = YES >> Doc.Config
ECHO EXTERNAL_PAGES         = YES >> Doc.Config
ECHO PERL_PATH              = /usr/bin/perl >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO # Configuration options related to the dot tool >> Doc.Config
ECHO #--------------------------------------------------------------------------- >> Doc.Config
ECHO CLASS_DIAGRAMS         = YES >> Doc.Config
ECHO MSCGEN_PATH            =  >> Doc.Config
ECHO DIA_PATH               =  >> Doc.Config
ECHO HIDE_UNDOC_RELATIONS   = YES >> Doc.Config
ECHO HAVE_DOT               = NO >> Doc.Config
ECHO DOT_NUM_THREADS        = 0 >> Doc.Config
ECHO DOT_FONTNAME           = Helvetica >> Doc.Config
ECHO DOT_FONTSIZE           = 10 >> Doc.Config
ECHO DOT_FONTPATH           =  >> Doc.Config
ECHO CLASS_GRAPH            = YES >> Doc.Config
ECHO COLLABORATION_GRAPH    = YES >> Doc.Config
ECHO GROUP_GRAPHS           = YES >> Doc.Config
ECHO UML_LOOK               = NO >> Doc.Config
ECHO UML_LIMIT_NUM_FIELDS   = 10 >> Doc.Config
ECHO TEMPLATE_RELATIONS     = NO >> Doc.Config
ECHO INCLUDE_GRAPH          = YES >> Doc.Config
ECHO INCLUDED_BY_GRAPH      = YES >> Doc.Config
ECHO CALL_GRAPH             = YES >> Doc.Config
ECHO CALLER_GRAPH           = YES >> Doc.Config
ECHO GRAPHICAL_HIERARCHY    = YES >> Doc.Config
ECHO DIRECTORY_GRAPH        = YES >> Doc.Config
ECHO DOT_IMAGE_FORMAT       = png >> Doc.Config
ECHO INTERACTIVE_SVG        = NO >> Doc.Config
ECHO DOT_PATH               =  >> Doc.Config
ECHO DOTFILE_DIRS           =  >> Doc.Config
ECHO MSCFILE_DIRS           =  >> Doc.Config
ECHO DIAFILE_DIRS           =  >> Doc.Config
ECHO PLANTUML_JAR_PATH      =  >> Doc.Config
ECHO PLANTUML_INCLUDE_PATH  =  >> Doc.Config
ECHO DOT_GRAPH_MAX_NODES    = 50 >> Doc.Config
ECHO MAX_DOT_GRAPH_DEPTH    = 0 >> Doc.Config
ECHO DOT_TRANSPARENT        = NO >> Doc.Config
ECHO DOT_MULTI_TARGETS      = NO >> Doc.Config
ECHO GENERATE_LEGEND        = YES >> Doc.Config
ECHO DOT_CLEANUP            = YES >> Doc.Config
ECHO [%DATE% %TIME%] Archivo de configuracion generado!

:GenerarDocumentacion
ECHO [%DATE% %TIME%] Generando documentacion...
IF EXIST doc\code ECHO [%DATE% %TIME%] Removiendo carpeta de salida... & rmdir /S /Q doc\code & ECHO [%DATE% %TIME%] Carpeta doc\code removida!
doxygen Doc.Config
IF NOT %ERRORLEVEL% == 0 EXIT/B 1
ECHO [%DATE% %TIME%] Documentacion generada!
ECHO [%DATE% %TIME%] Saliendo...