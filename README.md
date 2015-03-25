allure-vstest-logger
====================

[![Build status](https://ci.appveyor.com/api/projects/status/mh1cq0ubr498d92a?svg=true)](https://ci.appveyor.com/project/arpitgold/allure-vstest-logger)

This is a logger for the vstest.console.exe that generates an [allure](https://github.com/allure-framework) compatible xml using the [allure-csharp-commons](https://github.com/allure-framework/allure-csharp-commons).


Installation
============

The resulting VSTestAllureTestLogger.dll file should be copied to:

```
C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow\Extensions
```

together with all of its dependencies:

* AllureCSharpCommons.dll
* log4net.dll
* Microsoft.Experimental.Collections.dll

You will need an administrator's permissions to copy the file to the Extensions directory.

If you are copying the file over an older version and windows says the file is locked make sure a process named 'vstest.discoveryengine.x86.exe' is not running. If it is then close it and try again.

Usage
=====

Once the logger is installed it can be invoked using:

```
vstest.console.exe /logger:Allure <test dll>.dll
```

If you want the output to be written to another location other than the current directory you can specify it by using:
```
vstest.console.exe /logger:Allure;ResultsPath=<some dir> <test dll>.dll
```


If you would like to use another logger in conjunction with the Allure you can use the MulticastLogger!

Simply comma separate the loggers in loggers parameter, if any of the loggers have parameters you can use LoggerName.ParameterName to set the ParameterName parameter. For example:

```
vstest.console.exe tests.dll /logger:Multicast;loggers=Allure,trx,TfsPublisher;TfsPublisher.Collection=<team project url>;TfsPublisher.BuildName=<build name>;TfsPublisher.TeamProject=<team project name>;
```

You may also alias loggers, then you can set parameters on the aliases:

```
vstest.console.exe tests.dll /logger:Multicast;logger1=Allure;logger2=trx;logger3=TfsPublisher;logger3.Collection=<team project url>;logger3.BuildName=<build name>;logger3.TeamProject=<team project name>;
```


Compiling
=========
Make sure you have a reference to Microsoft.VisualStudio.TestPlatform.ObjectModel.dll from:
```
C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow
```
or
```
C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow
```
