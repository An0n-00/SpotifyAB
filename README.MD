<div align="center">
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors)
<!-- ALL-CONTRIBUTORS-BADGE:END -->

# Spotify AdBlocker (SpotifyAB)  

[![GitHub release (latest by date)](https://img.shields.io/github/v/release/An0n-00/SpotifyAB?display_name=tag&label=Latest%20Release&color=brightgreen)](https://github.com/An0n-00/SpotifyAB/releases)   [![GitHub issues](https://img.shields.io/github/issues/An0n-00/SpotifyAB?label=Issues&color=red)](https://github.com/An0n-00/SpotifyAB/issues)   [![GitHub forks](https://img.shields.io/github/forks/An0n-00/SpotifyAB?label=Forks&color=blue)](https://github.com/An0n-00/SpotifyAB/network/members)   [![GitHub stars](https://img.shields.io/github/stars/An0n-00/SpotifyAB?label=Stars&color=yellow)](https://github.com/An0n-00/SpotifyAB/stargazers)   [![GitHub license](https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-orange)](https://github.com/An0n-00/SpotifyAB/blob/main/LICENSE.md)   [![GitHub last commit](https://img.shields.io/github/last-commit/An0n-00/SpotifyAB?label=Last%20Commit&color=teal)](https://github.com/An0n-00/SpotifyAB/commits/main)   [![GitHub contributors](https://img.shields.io/github/contributors/An0n-00/SpotifyAB?label=Contributors&color=gold)](https://github.com/An0n-00/SpotifyAB/graphs/contributors)   [![GitHub downloads](https://img.shields.io/github/downloads/An0n-00/SpotifyAB/total?label=Downloads&color=purple)](https://github.com/An0n-00/SpotifyAB/releases) [![GitHub commit activity](https://img.shields.io/github/commit-activity/m/An0n-00/SpotifyAB?label=Monthly%20Commits&color=blue)](https://github.com/An0n-00/SpotifyAB/pulse)   [![GitHub open pull requests](https://img.shields.io/github/issues-pr/An0n-00/SpotifyAB?label=Open%20PRs&color=cyan)](https://github.com/An0n-00/SpotifyAB/pulls)

🎵 Welcome to the Spotify AdBlocker (SpotifyAB) repository by An0n-00, designed to block ads and trackers directly within the Spotify desktop app for Windows. 🚫📺

## Overview

This project utilizes JavaScript injection into the Spotify application to block ads and trackers, providing an uninterrupted listening experience without intrusive interruptions. 🎧🔇

</div>

### Anouncement

We are happy to announce that we have released a client app that automates the installation process. You can download the client app from the [latest release](https://github.com/An0n-00/SpotifyAB/releases/latest/download/SpotifyAB-Installer.exe) in this repository. 🚀

## Installation Guide

To install the Spotify AdBlocker, follow these steps:

1. **Download the Client App:**
   - Obtain the `SpotifyAB-Installer.exe` file from the [latest release](https://github.com/An0n-00/SpotifyAB/releases/latest/download/SpotifyAB-Installer.exe)
   - Run the installer to install the Spotify AdBlocker.
   - Choose the option that you want to do.

2. **Restart Spotify:**
Done! You have successfully installed the Spotify AdBlocker! 🎉

### Visuals

Here you have some images of the client app:
![Visual of the Client app](/docs/pics/visuals.png)

## Manual Installation Guide

To implement the Spotify AdBlocker, follow these steps:

1. **Download the Required File:**
   - Obtain the `xpui.spa` file from the [latest release](https://github.com/An0n-00/SpotifyAB/releases) in this repository.

2. **Replace the Existing File in Spotify Directory:**
   - Navigate to your Spotify installation directory:
     `C:\Users\_username_\AppData\Roaming\Spotify\Apps\`
   - Replace the existing `xpui.spa` file with the downloaded `xpui.spa` from step 1.
   - ~If you encounter issues, unzip the `xpui.spa` to `.\xpui\`~
   - Newly you have to have the `xpui.spa` and `\xpui` as a folder. (you can unzip the xpui.spa file with any other software that unzips .tar files)

> [!important]
> Please always read the newest release, as it may contain newer information than written here

3. **Restart Spotify:**
   - Close and reopen the Spotify desktop app to apply the changes.

You have successfully installed the Spotify AdBlocker! 🎉

> [!CAUTION]  
> ### Compatibility Notice:
> This method is specifically designed for the Spotify desktop app on Windows. **The Microsoft Store version is not supported.** 🖥️❌

## Verification Process

You can verify the functionality by examining the contents of the `xpui.spa` file:

- Unzip the `xpui.spa` file using any zip program.
- Explore the extracted files. The main file of interest is `./spotifyAB/AB.js` and the `index.html` file, which calls the JS file.
- The `AB.js` file contains the JavaScript code that blocks the ads.

---

## 🌟 How to Build the Client App

If you want to build the client app yourself, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/An0n-00/SpotifyAB.git
   cd SpotifyAB/SpotifyABClient
   ```

2. **Build the App:** 
   ```bash
   dotnet build --Configuration Release
   cd ./bin
   ```

3. **Test Your Build:**
   - Run the built `SpotifyAB.exe` and verify its functionality.

🎉 You’ve successfully built the SpotifyAB client app!

---

## Legal Information

- **License:** SpotifyAB by An0n-00 is [licensed under Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International](/license)
- **Disclaimer:** Use this software at your own risk. No warranties are provided. ⚠️

---

## Contributors

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://an0n-00.github.io/"><img src="https://avatars.githubusercontent.com/u/142223573?v=4?s=100" width="100px;" alt="Anon"/><br /><sub><b>Anon</b></sub></a><br /><a href="https://github.com/An0n-00/SpotifyAB/commits?author=An0n-00" title="Code">💻</a> <a href="https://github.com/An0n-00/SpotifyAB/commits?author=An0n-00" title="Documentation">📖</a> <a href="#design-An0n-00" title="Design">🎨</a> <a href="https://github.com/An0n-00/SpotifyAB/issues?q=author%3AAn0n-00" title="Bug reports">🐛</a> <a href="#blog-An0n-00" title="Blogposts">📝</a> <a href="#content-An0n-00" title="Content">🖋</a> <a href="#maintenance-An0n-00" title="Maintenance">🚧</a> <a href="#projectManagement-An0n-00" title="Project Management">📆</a> <a href="#question-An0n-00" title="Answering Questions">💬</a> <a href="#research-An0n-00" title="Research">🔬</a> <a href="https://github.com/An0n-00/SpotifyAB/pulls?q=is%3Apr+reviewed-by%3AAn0n-00" title="Reviewed Pull Requests">👀</a> <a href="#security-An0n-00" title="Security">🛡️</a> <a href="#tool-An0n-00" title="Tools">🔧</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

---

## Star History

<a href="https://star-history.com/#An0n-00/SpotifyAB&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=An0n-00/SpotifyAB&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=An0n-00/SpotifyAB&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=An0n-00/SpotifyAB&type=Date" />
 </picture>
</a>

---

## Useful Information

> [!TIP]
> I've published another project called [Spotify-ad-hosts](https://www.github.com/An0n-00/Spotify-ad-hosts) that used to block Spotify ads by modifying the hosts file. It did not work out properly due to Spotify's changes in the ad-serving mechanism. However, I recommend to add the domains to the hosts file as an additional layer of protection and to block trackers. 📝 Check it out! 📦

If you have any questions or encounter issues, please feel free to reach out by opening an issue on the GitHub repository. 📢

**Enjoy your ad-free Spotify experience with SpotifyAB!** 🎶🚀
