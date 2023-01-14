@ECHO OFF

IF EXIST "C:\Program Files (x86)\Microsoft Xbox 360 SDK\bin\win32\windbg.exe" (
	"C:\Program Files (x86)\Microsoft Xbox 360 SDK\bin\win32\windbg.exe" /k net:port=5543
)

IF EXIST "C:\Program Files\Microsoft Xbox 360 SDK\bin\win32\windbg.exe" (
	"C:\Program Files\Microsoft Xbox 360 SDK\bin\win32\windbg.exe" /k net:port=5543
)

