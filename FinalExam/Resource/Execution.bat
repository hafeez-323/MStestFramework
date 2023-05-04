@ECHO OFF
ECHO Demo Automation Executed Started.

set dllpath=C:\Users\mujee\source\repos\FinalExam\FinalExam\bin\Debug\FinalExam.dll
set trxtoHTML=C:\Users\mujee\source\repos\FinalExam\FinalExam\bin\Debug\
set testsummaryreportPath=C:\Users\mujee\source\repos\FinalExam\FinalExam\TestSummaryReport\

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
cd %testsummaryreportPath%


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%testsummaryreportPath%\%filename%\%filename%.trx"

cd %trxtoHTML%
TrxToHTML.exe %testsummaryreportPath%%filename%\

PAUSE