# Tucker Tech's Google Apps Drive Backup (TTO-GDB)

[![Join the chat at https://gitter.im/mtucker6784/tto-googlebackup](https://badges.gitter.im/mtucker6784/tto-googlebackup.svg)](https://gitter.im/mtucker6784/tto-googlebackup?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Stories in Ready](https://badge.waffle.io/mtucker6784/tto-googlebackup.png?label=ready&title=Ready)](https://waffle.io/mtucker6784/tto-googlebackup)

Tucker Tech's Free Google Apps Drive backup utility (TTO Google Backup) --- C# Drive API v3

Backup tool for backing up Google Apps Drive environments. This uses the Drive API v3 and C# (.net 4.5)

I developed this because I want to be able to backup my domain to my SAN & backup server. There are solutions out there, but they cost a lot of money and I'm still left in their hands. I also wanted a GUI friendly approach, hopefully others may find this useful in their environment as well.

This program will read a TXT file that contains only one column, which is where your useraccount@yourgappsdomain.xyz accounts are. It also supports a very rudimentary version of an LDAP AD connection. Type in your domain name and let it go.

I have a lot of trial and error with this project (with blood sweat and tears), so please know I understand it needs some more care. With that said, I will always welcome PRs if you're interested in improving it.

The "core" code I used is mainly built on what Google already gives developers and can be found at the following URL: https://developers.google.com/drive/v3/web/quickstart/dotnet
I merely added some more "logic" to it to offer more flexibility.

At this time, I'm mainly concerned about backing up drive documents, so that's the only scope I'm pulling from, although you can really pull from any scope you want (email, calendar, etc.) but those options are not native to this app yet.

Main website http://www.tuckertechonline.com/
Documentation portal, including features, known issues and rev changes: https://ttobackup.readme.io/
Roadmap/under development features: https://waffle.io/mtucker6784/tto-googlebackup)

Hope this helps others who are looking for a similar solution!

If you download the solution and plan to compile it, make sure to download the NuGet repository for the Google Apps Drive (v3) tools. This can be done by opening the NuGet manager in VS and typing in: "Install-Package Google.Apis.Drive.v3" (Without quotes). You will also need to download the MetroUI framework from NuGet. There may be another step or two I'm forgetting, but feel free to ask and I'll be glad to help.

Binary download is on the releases page (https://github.com/mtucker6784/tto-googlebackup/releases)

Please understand that I know the code is very elementary, but it's enough to get the ball rolling.
