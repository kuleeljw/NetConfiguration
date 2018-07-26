[quote]
@echo off
echo .
echo .
echo .
echo 配置本机网络属性:
set slection1=%1
netsh interface ip set address name="本地连接" source=static addr=%slection1% mask=255.255.255.0
set slection2=%2
netsh interface ip set address name="本地连接" gateway=%slection2% gwmetric=0
set slection3=%3
netsh interface ip set dns name="本地连接" source=static addr=%slection3% register=PRIMARY
set slection4=%4
netsh interface ip add dns name="本地连接" addr=%slection4%
netsh interface ip set wins name="本地连接" source=static addr=none
pause