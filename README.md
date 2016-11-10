# Tucker Tech's Google Apps Drive Backup (TTO-GDB)

[![Join the chat at https://gitter.im/mtucker6784/tto-googlebackup](https://badges.gitter.im/mtucker6784/tto-googlebackup.svg)](https://gitter.im/mtucker6784/tto-googlebackup?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Stories in Ready](https://badge.waffle.io/mtucker6784/tto-googlebackup.png?label=ready&title=Ready)](https://waffle.io/mtucker6784/tto-googlebackup)

Tucker Tech's Free Google Apps Drive backup utility (TT-GDB) --- C# Drive API v3

Backup tool for backing up Google Apps Drive environments. This uses the Drive API v3 and C# (.net 4.5)

I developed this because I want to be able to backup my domain to my SAN & backup server. There are solutions out there, but they cost a lot of money and I'm still left in their hands. I also wanted a GUI friendly approach that I think others may be interested in the future.

This program will read a TXT file that contains only one column, which is where your useraccount@yourgappsdomain.xyz accounts are. It also supports a very rudimentary version of an LDAP AD connection. Type in your domain name and let it go.

I have a lot of trial and error with this project, so I hope others may find it useful. I will always welcome PRs if you're interested in improving it.

Sites of interest: http://www.tuckertechonline.com/ , Particularly http://www.tuckertechonline.com/foss-google-drive-backup-directions/ ... There is more information + screenshots of what to do on that page.
Directions: 

The "core" code I used is mainly built on what Google already gives developers and can be found at the following URL: https://developers.google.com/drive/v3/web/quickstart/dotnet
I merely added some more "logic" to it to offer more flexibility.

At this time, I'm mainly concerned about backing up drive documents, so that's the only scope I'm pulling from, although you can really pull from any scope you want (email, drive, calendar, etc.) but those options are not native to this app yet.

Known issue(s) / concerns / future plans:

1. Create master log file for overall status. A log file is currently written for each user and streamed to their root drive directory.
2. Add restore feature

Hope this helps others who are looking for a similar solution!

The Syncfusion.com Winform controls are now necessary to compile this solution. the controls are free for those who want to create an account and develop "free" software. 

If you download the solution and plan to compile it, make sure to download the NuGet repository for the Google Apps Drive (v3) tools. This can be done by opening the NuGet manager in VS and typing in: "Install-Package Google.Apis.Drive.v3" (Without quotes). There may be another step or two I'm forgetting, but feel free to ask and I'll be glad to help.

Binary download is on the releases page (https://github.com/mtuckerinaz/Gapps-backup/releases)
See http://www.tuckertechonline.com/ for instructions + screenshots

Please understand that I know the code is very elementary, but it's enough to get the ball rolling.
