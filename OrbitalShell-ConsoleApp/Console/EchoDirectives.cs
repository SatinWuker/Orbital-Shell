﻿namespace DotNetConsoleAppToolkit.Console
{

    /// <summary>
    /// <para>
    /// constants by category:<br/>
    ///
    /// -------------- <br/>
    /// Specials caracters <br/>
    /// -------------- <br/>
    /// 
    ///     ESC<br/>
    ///     CRLF<br/>
    ///     CSI<br/>
    /// 
    /// --------------<br/>
    /// ANSI sequences<br/>
    /// --------------<br/>
    /// 
    /// DECSC<br/>
    /// DECRC<br/>
    /// RIS<br/>
    /// RSTXTA<br/>
    /// RSCOLDEF<br/>
    /// CUU<br/>
    /// CUD<br/>
    /// CUF<br/>
    /// CUB<br/>
    /// CNL<br/>
    /// CPL<br/>
    /// CHA<br/>
    /// CUP<br/>
    /// SU<br/>
    /// SD<br/>
    /// DSR<br/>
    /// ED<br/>
    /// EL<br/>
    /// SGR_Reset<br/>
    /// SGR_IncreasedIntensity<br/>
    /// SGR_DecreaseIntensity<br/>
    /// SGR_Italic<br/>
    /// SGR_Underline<br/>
    /// SGR_SlowBlink<br/>
    /// SGR_RapidBlink<br/>
    /// SGR_ReverseVideo<br/>
    /// SGR_ItalicOff<br/>
    /// SGR_UnderlineOff<br/>
    /// SGR_BlinkOff<br/>
    /// SGR_ReverseOff<br/>
    /// SGR_NotCrossedOut<br/>
    /// SGR_CrossedOut<br/>
    /// SGR_DoubleUnderline<br/>
    /// SGR_NormalIntensity<br/>
    /// SGRF<br/>
    /// SGRF8<br/>
    /// SGRF24<br/>
    /// SGRB<br/>
    /// SGRB8<br/>
    /// SGRB24<br/>
    /// 
    /// -------<br/>
    /// colors:<br/>
    /// -------<br/>
    /// 
    ///       set foreground:     f=consoleColor<br/>
    ///       set background:     b=consoleColor<br/>
    ///       set default foreground: df=consoleColor<br/>
    ///       set default background: db=consoleColor<br/>
    ///       backup foreground:  bkf<br/>
    ///       backup background:  bkb<br/>
    ///       restore foreground: rsf<br/>
    ///       restore background: rsb<br/>
    ///       set colors to defaults: rdc<br/>
    ///       consoleColor (ignoreCase) := black | darkblue | darkgreen | darkcyan | darkred  | darkmagenta | darkyellow | gray | darkgray  | blue | green | cyan  | red  | magenta  | yellow  | white     (case insensitive)<br/>
    ///
    /// -------------------<br/>
    /// print flow control:<br/>
    /// -------------------<br/>
    ///
    ///       clear console: cl<br/>
    ///       line break: br<br/>
    ///       backup cursor pos: bkcr<br/>
    ///       restore cursor pos: rscr<br/>
    ///       set cursor left: crx=<br/>
    ///       set cursor top: cry=<br/>
    /// 
    /// ------------<br/>
    /// app control:<br/>
    /// ------------<br/>
    /// 
    ///       exit: exit<br/>
    /// 
    /// ----------------<br/>
    /// scripts engines:<br/>
    /// ----------------<br/>
    /// 
    ///       exec: exec csharp from text<br/>
    /// ------------------------<br/>
    /// text decoration (vt100):<br/>
    /// ------------------------<br/>
    /// 
    ///       underline on: uon<br/>
    ///       inverted text on: invon<br/>
    ///       text decoration off: tdoff<br/>
    ///       low intensity: lion<br/>
    ///       blon: blinkon<br/>
    ///       bon: boldon<br/>
    /// 
    /// </para>
    /// <para>
    /// ------------------------------<br/>
    /// echo directives global syntax:<br/>
    /// ------------------------------<br/>
    ///     commandBlockBegin command commandValueAssignationChar value (commandSeparatorChar command commandValueAssignationChar value) commandBlockEnd<br/>
    ///     commandBlockBegin := (<br/>
    ///     commandBlockEnd := )<br/>
    ///     commandValueAssignationChar := =<br/>
    ///     commandSeparatorChar := ,<br/>
    ///     value := string_without_CommandBlockBegin_and_CommandBlockEnd) | ( codeBlockBegin any codeBlockEnd )<br/>
    ///     any := string<br/>
    ///     odeBlockBegin ::= [[<br/>
    ///     codeBlockEnd ::= ]]<br/>
    ///     syntactic elements can be changed for convenience &amp; personal preference<br/>
    /// </para>
    /// </summary>
    public enum EchoDirectives
    {
        // @TODO : nommages à revoir

        #region ANSI_Sequences

        /// <summary>
        /// ESC (char 27d)
        /// </summary>
        ESC,

        /// <summary>
        /// new line (depends on environment)
        /// </summary>
        CRLF,

        /// <summary>
        /// Control Sequence Introducer
        /// </summary>
        CSI,

        /// <summary>
        /// backup cursor position
        /// </summary>
        DECSC,
        
        /// <summary>
        /// restore cursor position
        /// </summary>
        DECRC,

        /// <summary>
        /// Triggers a full reset of the terminal
        /// </summary>
        RIS,

        /// <summary>
        /// RESET TEXT ATTRIBUTES (hack)
        /// </summary>
        RSTXTA,

        /// <summary>
        /// reset terminal colors
        /// </summary>
        RSCOLDEF,

        /// <summary>
        /// Cursor up
        /// </summary>        
        CUU,

        /// <summary>
        /// Cursor Down
        /// </summary>      
        CUD,

        /// <summary>
        /// Cursor Forward
        /// </summary>
        CUF,

        /// <summary>
        /// Cursor Back
        /// </summary>
        CUB,

        /// <summary>
        /// Cursor Next Line
        /// </summary>
        CNL,

        /// <summary>
        /// Cursor Previous Line
        /// </summary>
        CPL,

        /// <summary>
        /// Cursor Horizontal Absolute
        /// </summary>
        CHA,

        /// <summary>
        /// Cursor Position
        /// </summary>
        CUP,

        /// <summary>
        /// Scroll Up
        /// </summary>
        SU,

        /// <summary>
        /// Scroll Down
        /// </summary>
        SD,

        /// <summary>
        /// Device Status Report - Reports the cursor position
        /// </summary>
        DSR,

        /// <summary>
        /// Erases part of the screen
        /// </summary>
        ED,

        /// <summary>
        /// Erases part of the line
        /// </summary>
        EL,

        /// <summary>
        /// Reset / Normal - All attributes off
        /// </summary>
        SGR_Reset,

        /// <summary>
        /// Bold or increased intensity
        /// </summary>
        SGR_IncreasedIntensity,

        /// <summary>
        /// Faint or decreased intensity
        /// </summary>
        SGR_DecreaseIntensity,

        /// <summary>
        /// Italic
        /// </summary>
        SGR_Italic,

        /// <summary>
        /// Underline
        /// </summary>
        SGR_Underline,

        /// <summary>
        /// Slow Blink
        /// </summary>
        SGR_SlowBlink,

        /// <summary>
        /// Rapid Blink
        /// </summary>
        SGR_RapidBlink,


        /// <summary>
        /// 
        /// </su
        /// </summary>
        SGR_ReverseVideo,

        /// <summary>
        /// Italic off
        /// </summary>
        SGR_ItalicOff,

        /// <summary>
        ///Underline off
        /// </summary>
        SGR_UnderlineOff,

        /// <summary>
        /// BlinkOff
        /// </summary>
        SGR_BlinkOff,

        /// <summary>
        /// ReverseOff
        /// </summary>
        SGR_ReverseOff,

        /// <summary>
        /// NotCrossedOut
        /// </summary>
        SGR_NotCrossedOut,

        /// <summary>
        /// CrossedOut
        /// </summary>
        SGR_CrossedOut,

        /// <summary>
        /// DoubleUnderline
        /// </summary>
        SGR_DoubleUnderline,

        /// <summary>
        /// NormalIntensity
        /// </summary>
        SGR_NormalIntensity,

        /// <summary>
        /// Set foreground color - 3/4 bits palette mode : SGRF=0<=n<=7[,bright]
        /// </summary>
        SGRF,

        /// <summary>
        /// set foreground color - 8 bits palette (256 colors) : SGRF8=0<=n<=255
        /// </summary>
        SGRF8,

        /// <summary>
        /// set foreground color - 24 bits 'true color' : SGRF24=0<=n<=255,0<=n<=255,0<=n<=255 (r,g,b)
        /// </summary>
        SGRF24,

        /// <summary>
        /// Set background color - 3/4 bits palette mode : SGRF=0<=n<=7[,bright]
        /// </summary>
        SGRB,

        /// <summary>
        /// set background color - 8 bits palette (256 colors) : SGRF8=0<=n<=255
        /// </summary>
        SGRB8,

        /// <summary>
        /// set background color - 24 bits 'true color' : SGRF24=0<=n<=255,0<=n<=255,0<=n<=255 (r,g,b)
        /// </summary>
        SGRB24,

        #endregion

        /// <summary>
        /// backup foreground in the shell backup memory
        /// </summary>
        bkf,        

        /// <summary>
        /// backup background in the shell backup memory
        /// </summary>
        bkb,

        /// <summary>
        /// restore foreground from the shell default foreground setting
        /// </summary>
        rsf,

        /// <summary>
        /// restore background from shell default background setting
        /// </summary>
        rsb,

        /// <summary>
        /// set colors to defaults from shell  default foreground and background colors
        /// </summary>
        rdc,

        /// <summary>
        /// set foreground from 4 bits palette : f=red (from ConsoleColor not case sensitive values)
        /// </summary>
        f,

        /// <summary>
        /// set foreground from 8 bits palette : f8=0<=n<=255
        /// </summary>
        f8,

        /// <summary>
        /// set foreground from 24 bits color : f24=r:g:b with 0<=r,g,b<=255
        /// </summary>
        f24,

        /// <summary>
        /// set background from 4 bits palette  : b=red (from ConsoleColor not case sensitive values)
        /// </summary>
        b,

        /// <summary>
        /// set background from 8 bits palette : b8=0<=n<=255
        /// </summary>
        b8,

        /// <summary>
        /// set background from 24 bits color : b24=r:g:b with 0<=r,g,b<=255
        /// </summary>
        b24,

        /// <summary>
        /// set default foreground : assign the shell default foreground memory
        ///<para>set the system console foreground</para>
        /// </summary>
        df,

        /// <summary>
        /// set default background : assign the shell default background memory
        /// <para>set the system console background</para>
        /// </summary>
        db,

        /// <summary>
        /// line break - @Uses ConsoleTextWrapper.LineBreak
        /// </summary>
        br,

        /// <summary>
        /// infos about console
        /// </summary>
        inf,

        /// <summary>
        /// backup cursor pos in shell memory - @Uses system console cursor position
        /// </summary>
        bkcr,

        /// <summary>
        /// restore cursor pos from shell memory - @Uses @2J@[{top+1};{left+1})H
        /// </summary>
        rscr,

        /// <summary>
        /// hide cursor - @Uses system console
        /// </summary>
        crh,

        /// <summary>
        /// show cursor - @Uses system console
        /// </summary>
        crs,

        /// <summary>
        /// set cursor left (x) - @Uses @[{x+1}G (get @uses system console)
        /// </summary>
        crx,

        /// <summary>
        /// set cursor top (y) - @Uses @2J@[{top+1};{left+1})H [@TODO: avoid also set X !!!!] (get @uses system console)
        /// </summary>
        cry,

        /// <summary>
        /// exit the current process
        /// </summary>
        exit,

        /// <summary>
        /// exec csharp code from text
        /// </summary>
        exec,

        /// <summary>
        /// clear screen - @Uses ConsoleTextWriterWrapper
        /// </summary>
        cls,

        /// <summary>
        /// underline on - sgr
        /// </summary>
        uon,

        /// <summary>
        /// bold on - sgr
        /// </summary>
        bon,

        /// <summary>
        /// blink on - sgr
        /// </summary>
        blon,

        /// <summary>
        /// invert/reverse on - sgr
        /// </summary>
        invon,

        /// <summary>
        /// light colors - sgr
        /// </summary>
        lion,

        /// <summary>
        /// text decoration off - sgr
        /// </summary>
        tdoff,

        /// <summary>
        /// fill current line to the right - shell impl. (@TODO: remove)
        /// </summary>
        fillright,

        /// <summary>
        /// clear line from cursor right - @[K
        /// </summary>
        clright,

        /// <summary>
        /// clear line from cursor left - @[1K
        /// </summary>
        clleft,

        /// <summary>
        /// clear entire line - @[2K
        /// </summary>
        cl,

        /// <summary>
        /// cursor up - @[1A
        /// </summary>
        cup,

        /// <summary>
        /// cursor down - @[1B
        /// </summary>
        cdown,

        /// <summary>
        /// cursor left - @[1D
        /// </summary>
        cleft,

        /// <summary>
        /// cursor right- @[1C
        /// </summary>
        cright,

        /// <summary>
        /// cursor n lines up - @[1{n}A 
        /// </summary>
        cnup,

        /// <summary>
        /// cursor n lines down - @[{n}B
        /// </summary>
        cndown,

        /// <summary>
        /// cursor n cells left - @[{n}D
        /// </summary>
        cnleft,

        /// <summary>
        /// cursor n cells right- @[{n}C
        /// </summary>
        cnright,

        /// <summary>
        /// cursor home (top left 0,0) - @[H
        /// </summary>
        chome
    }
}
