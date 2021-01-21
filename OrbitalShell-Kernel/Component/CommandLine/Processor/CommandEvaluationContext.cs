﻿using DotNetConsoleAppToolkit.Component.CommandLine.Variable;
using DotNetConsoleAppToolkit.Console;
using System.IO;
using System;

namespace DotNetConsoleAppToolkit.Component.CommandLine.Processor
{
    public class CommandEvaluationContext
    {
        static int _instanceCounter = 1000;
        static object _instanceLock = new object();

        /// <summary>
        /// context id
        /// </summary>
        public int ID = -1;

        public readonly CommandLineProcessor CommandLineProcessor;
        public readonly ConsoleTextWriterWrapper Out;
        public readonly TextWriterWrapper Err;
        public readonly TextReader In;
        public readonly object InputData;        
        public readonly CommandEvaluationContext ParentContext;

        public readonly Variables Variables;
        public ShellEnvironment ShellEnv { get; protected set; }
        public EchoPrimitiveMap EchoMap { get; protected set; }

        public CommandEvaluationContext(            
            CommandLineProcessor commandLineProcessor, 
            ConsoleTextWriterWrapper @out, 
            TextReader @in, 
            TextWriterWrapper err, 
            object inputData,
            CommandEvaluationContext parentContext = null)
        {
            lock (_instanceLock)
            {
                ID = _instanceCounter;
                _instanceCounter++;
            }

            CommandLineProcessor = commandLineProcessor;
            Out = @out;
            In = @in;
            Err = err;
            InputData = inputData;

            SetupShellEnvVar();
            Variables = new Variables( (VariableNamespace.env, ShellEnv) );
            ShellEnv.Initialize(this);

            EchoMap = new EchoPrimitiveMap();
            ParentContext = parentContext;
            
            @out.ColorSettings = ShellEnv.Colors;
        }

        void SetupShellEnvVar()
        {
            ShellEnv = new ShellEnvironment(VariableNamespace.env+"");         
        }

        public void Errorln(string s) => Error(s, true);

        public void Error(string s, bool lineBreak = false)
        {
            lock (Out.Lock)
            {
                Out.RedirecToErr = true;
                Out.Echo($"{ShellEnv.Colors.Error}{s}{ShellEnv.Colors.Default}", lineBreak);
                Out.RedirecToErr = false;
            }
        }
    }
}
