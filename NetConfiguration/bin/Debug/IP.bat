[quote]
@echo off
echo .
echo .
echo .
echo ���ñ�����������:
set slection1=%1
netsh interface ip set address name="��������" source=static addr=%slection1% mask=255.255.255.0
set slection2=%2
netsh interface ip set address name="��������" gateway=%slection2% gwmetric=0
set slection3=%3
netsh interface ip set dns name="��������" source=static addr=%slection3% register=PRIMARY
set slection4=%4
netsh interface ip add dns name="��������" addr=%slection4%
netsh interface ip set wins name="��������" source=static addr=none
pause