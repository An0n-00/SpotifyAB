<div align="center">
# Spotify AdBlocker (SpotifyAB)

🎵 Welcome to the Spotify AdBlocker (SpotifyAB) repository by An0n-00, designed to block ads directly within the Spotify desktop app for Windows. 🚫📺

## Overview

This project utilizes JavaScript injection into the Spotify application to block ads, providing an uninterrupted listening experience without intrusive interruptions. 🎧🔇

</div>

### Anouncement

There will be a client app to automate the installation process and to provide a user-friendly interface. Stay tuned for updates! 🔄

## Installation Guide

To implement the Spotify AdBlocker, follow these steps:

1. **Download the Required File:**
   - Obtain the `xpui.spa` file from the [latest release](https://github.com/An0n-00/SpotifyAB/releases) in this repository.

2. **Replace the Existing File in Spotify Directory:**
   - Navigate to your Spotify installation directory:
     `C:\Users\_username_\AppData\Roaming\Spotify\Apps\`
   - Replace the existing `xpui.spa` file with the downloaded `xpui.spa` from step 1.

3. **Restart Spotify:**
   - Close and reopen the Spotify desktop app to apply the changes.

You have successfully installed the Spotify AdBlocker! 🎉

> [!CAUTION]  
> ### Compatibility Notice:
> This method is specifically designed for the Spotify desktop app on Windows. **The Microsoft Store version is not supported.** 🖥️❌

> [!NOTE]  
> There is a client app in progress to automate the installation process. Stay tuned for updates! 🔄

## Verification Process

You can verify the functionality by examining the contents of the `xpui.spa` file:

- Unzip the `xpui.spa` file using any zip program.
- Explore the extracted files. The main file of interest is `./spotifyAB/block-sections.js` and the `index.html` file, which calls the js.
- The `block-sections.js` file contains the JavaScript code that blocks the ads.
- And the `xpui.js` file is the main JavaScript file that is injected into the Spotify app to block ads.

## Legal Information

- **License:** This project is licensed under the MIT License. 📜
- **Disclaimer:** Use this software at your own risk. No warranties are provided. ⚠️

---
<br>

## Useful Information

> [!NOTE]  
> Injecting JavaScript into applications can alter their behavior. Make sure to adhere to the licensing terms and legal implications when modifying software. 🛡️

> [!TIP]
> I've published another project called [Spotify-ad-hosts](https://www.github.com/An0n-00/Spotify-ad-hosts) that used to block Spotify ads by modifying the hosts file. It did not work out properly due to Spotify's changes in the ad-serving mechanism. However, I recommend to add the domains to the hosts file as an additional layer of protection and to block trackers. 📝 Check it out! 📦

If you have any questions or encounter issues, please feel free to reach out by opening an issue on the GitHub repository. 📢

**Enjoy your ad-free Spotify experience with SpotifyAB!** 🎶🚀
