@pushd %~dp0
set "projectPath=C:\Users\JamisLiao\Documents\Visual Studio 2015\Projects\Pickles_Website_MsTest_Lab"
set "projectTestPath=%projectPath%\Pickles_Website_MsTest_Lab.Test"

echo %projectPath%\TestResults\TestResult.trx
if Exist %projectPath%\TestResults\TestResult.trx
del "%projectPath%\TestResults\TestResult.trx"

cd C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\
MsTest.exe /testcontainer:"%projectTestPath%\bin\Debug\Pickles_Website_MsTest_Lab.Test.dll" /resultsfile:"%projectPath%\TestResults\TestResult.trx"

@pushd %~dp0
@cd ..\
set "root=%CD%"

@set "reportPath=%root%\TestResults\TestResult.trx"
echo testResult : "%reportPath%"

@set "pickleReportPath=%root%\PicklesResults"
@pushd %~dp0
@set "feature=%CD%"

@cd ..\packages\Pickles.CommandLine.*\tools
pickles.exe run --feature-directory="%feature%" --output-directory="%pickleReportPath%" --documentation-format="dhtml" --test-results-format=mstest --link-results-file="%reportPath%"

@cd ..\Pickles_Website_MsTest_Lab.Test
@popd