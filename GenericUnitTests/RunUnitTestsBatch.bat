@echo off
set VSTest=C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe

"%VSTest%" D:\Git\AddressBookApp\GenericUnitTests\bin\Debug\GenericUnitTests.dll

pause