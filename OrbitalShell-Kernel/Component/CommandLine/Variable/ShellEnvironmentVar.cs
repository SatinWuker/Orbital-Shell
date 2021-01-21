﻿namespace DotNetConsoleAppToolkit.Component.CommandLine.Variable
{
    /// <summary>
    /// standard shell environment namespaces
    /// </summary>
    public enum ShellEnvironmentVar
    {        
        // traditional bash special variables

        /// <summary>
        /// last command return code
        /// </summary>
        sp__lastCommandReturnCode = '?',

        /// <summary>
        /// last command error text (if any, else blank) (extension to bash special vars)
        /// </summary>     
        sp__lastCommandErrorText = '%',
        
        /// <summary>
        /// 💥 active shell pid: should be '$' , but can't due to parser failure. so currently is '§'
        /// </summary>
        sp__activeShellPID = '§',

        /// <summary>
        /// active shell context id (extension to bash special vars)
        /// </summary>
        sp__activeShellContextID = 'µ',

        /// <summary>
        /// active shell thread id (extension to bash special vars)
        /// </summary>
        sp__activeShellThreadID = '|',
        
        /// <summary>
        /// in bash is a process id, for orbital shell is a thread id
        /// </summary>
        sp__lastTaskThreadID = '!',

        /// <summary>
        /// 💥 shell options: should be '-' , but can't due to parser failure. so currently is '°' (empty string if not defined)
        /// </summary>
        sp__shellOpts = '°',

        /// <summary>
        /// active shell args list (separator ' ') (empty string if not defined)
        /// </summary>
        sp__ArgList = '*',
        
        /// <summary>
        /// active shell separated args list (separator ',',args are quoted) (empty string if not defined)
        /// </summary>
        sp__ArgSepList = '@',
        
        /// <summary>
        /// args count
        /// </summary>
        sp__ArgsCount = '#',

        // batch args

        /// <summary>
        /// arg at 0 (empty string if not defined)
        /// </summary>        
        sp__arg0 = '0',

        /// <summary>
        /// arg at 1 (empty string if not defined)
        /// </summary>     
        sp__arg1 = '1',

        /// <summary>
        /// arg at 2 (empty string if not defined)
        /// </summary>     
        sp__arg2 = '2',

        /// <summary>
        /// arg at 3 (empty string if not defined)
        /// </summary>     
        sp__arg3 = '3',

        /// <summary>
        /// arg at 4 (empty string if not defined)
        /// </summary>     
        sp__arg4 = '4',

        /// <summary>
        /// arg at 5 (empty string if not defined)
        /// </summary>     
        sp__arg5 = '5',

        /// <summary>
        /// arg at 6 (empty string if not defined)
        /// </summary>     
        sp__arg6 = '6',

        /// <summary>
        /// arg at 7 (empty string if not defined)
        /// </summary>     
        sp__arg7 = '7',

        /// <summary>
        /// arg at 8 (empty string if not defined)
        /// </summary>     
        sp__arg8 = '8',

        /// <summary>
        /// arg at 9 (empty string if not defined)
        /// </summary>     
        sp__arg9 = '9',

        /// <summary>
        /// last command return code
        /// </summary>     
        lastComReturnCode = 0,

        /// <summary>
        /// last command error text (if any, else blank)
        /// </summary>     
        lastComErrorText = 41,

        /// <summary>
        /// active shell pid
        /// </summary>
        activeShellPID = 1,

        /// <summary>
        /// active shell thread id (extension to bash special vars)
        /// </summary>
        activeShellThreadID = 40,

        /// <summary>
        /// active shell context id (extension to bash special vars)
        /// </summary>
        activeShellContextID = 10000,

        /// <summary>
        /// args count
        /// </summary>
        argsCount = 10001,

        /// <summary>
        /// in bash is a process id, for orbital shell is a thread id
        /// </summary>
        lastTaskThreadID = 2,

        /// <summary>
        /// shell options (empty string if not defined)
        /// </summary>
        shellOpts = 3,

        /// <summary>
        /// active shell args list (separator ' ') (empty string if not defined)
        /// </summary>
        argList = 4,

        /// <summary>
        /// active shell separated args list (separator ',',args are quoted) (empty string if not defined)
        /// </summary>
        argSepList = 5,

        /// <summary>
        /// arg at 0 (not defined if not provided)
        /// </summary>
        arg0 = 6,

        /// <summary>
        /// arg at 1 (not defined if not provided)
        /// </summary>
        arg1 = 7,

        /// <summary>
        /// arg at 2 (not defined if not provided)
        /// </summary>
        arg2 = 8,

        /// <summary>
        /// arg at 3 (not defined if not provided)
        /// </summary>
        arg3 = 9,

        /// <summary>
        /// arg at 4 (not defined if not provided)
        /// </summary>
        arg4 = 10,

        /// <summary>
        /// arg at 5 (not defined if not provided)
        /// </summary>
        arg5 = 11,

        /// <summary>
        /// arg at 6 (not defined if not provided)
        /// </summary>
        arg6 = 12,

        /// <summary>
        /// arg at 7 (not defined if not provided)
        /// </summary>
        arg7 = 13,

        /// <summary>
        /// arg at 8 (not defined if not provided)
        /// </summary>
        arg8 = 14,

        /// <summary>
        /// arg at 9 (not defined if not provided)
        /// </summary>
        arg9 = 15,

        /// <summary>
        /// if enabled, activate codes that try to fix bad known console behaviors (eg. VSCode)
        /// </summary>
        settings_enableConsoleCompatibilityMode = 16,

        /// <summary>
        /// initial console width
        /// </summary>
        settings_consoleInitialWindowWidth = 17,

        /// <summary>
        /// initial console height
        /// </summary>
        settings_consoleInitialWindowHeight = 18,

        /// <summary>
        /// current prompt text
        /// </summary>       
        settings_prompt = 19,

        /// <summary>
        /// if enabled, activate a fix that cleanup properly end of lines (ConsoleTextWrapper.LNBRK)
        /// </summary>
        settings_enableAvoidEndOfLineFilledWithBackgroundColor = 20,

        /// <summary>
        /// if enabled, trace information about pipelines analysis
        /// </summary>
        debug_pipeline = 21,

        /// <summary>
        /// table formatting options
        /// </summary>
        display_tableFormattingOptions = 22,

        /// <summary>
        /// file system path formatting options
        /// </summary>
        display_fileSystemPathFormattingOptions = 23,
        
        /// <summary>
        /// colors settings
        /// </summary>
        display_colors_colorSettings = 24,

        /// <summary>
        /// user profile folder path
        /// </summary>
        userProfile = 25,

        // traditional bash variables

        /// <summary>
        /// user os home path
        /// </summary>
        home = 26,

        /// <summary>
        /// shell home path (binaries and content)
        /// </summary>
        shell = 27,

        /// <summary>
        /// shell version
        /// </summary>
        SHELL__VERSION = 28,

        /// <summary>
        /// shell name (exec name)
        /// </summary>
        SHELL__NAME = 29,

        /// <summary>
        /// shell long name
        /// </summary>
        SHELL__LONG__NAME = 30,

        /// <summary>
        /// information about shell's editor
        /// </summary>
        SHELL__EDITOR = 31,

        /// <summary>
        /// shell licence name
        /// </summary>
        SHELL__LICENSE = 32,        
    }
}
