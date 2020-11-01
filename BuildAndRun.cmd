@echo off
setlocal enabledelayedexpansion
call tooling\vs-tools
ilasm /dll MyStruct.il && dotnet run
