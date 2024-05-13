# Spotify AdBlocker (SpotifyAB)

🎵 Welcome to the Spotify AdBlocker (SpotifyAB) repository by An0n-00, designed to block ads directly within the Spotify desktop app for Windows. 🚫📺

## Overview

This project utilizes JavaScript injection into the Spotify application to block ads, providing an uninterrupted listening experience without intrusive interruptions. 🎧🔇

## Installation Guide

To implement the Spotify AdBlocker, follow these steps:

1. **Download the Required File:**
   - Obtain the `xpui.spa` file from the [latest release](https://github.com/an0n-00/SpotifyAB/releases/latest/download/xpui.spa) in this repository.

2. **Replace the Existing File in Spotify Directory:**
   - Navigate to your Spotify installation directory:
     `C:\Users\_username_\AppData\Roaming\Spotify\Apps\`
   - Replace the existing `xpui.spa` file with the downloaded `xpui.spa` from step 1.


> [!CAUTION]  
> ### Compatibility Notice:*
> This method is specifically designed for the Spotify desktop app on Windows. **The Microsoft Store version is not supported.** 🖥️❌

> [!NOTE]  
> There is a client app in progress to automate the installation process. Stay tuned for updates! 🔄

## Verification Process

You can verify the functionality by examining the contents of the `xpui.spa` file:

- Unzip the `xpui.spa` file using any zip program.
- Explore the extracted files. The main file of interest is `./SpotifyAB/block-sections.js` and the `index.html` file.

## Legal Information

- **License:** This project is licensed under the MIT License. 📜
- **Disclaimer:** Use this software at your own risk. No warranties are provided. ⚠️

---

**Note:** Injecting JavaScript into applications can alter their behavior. Make sure to adhere to the licensing terms and legal implications when modifying software. 🛡️

If you have any questions or encounter issues, please feel free to reach out by opening an issue on the GitHub repository. 📢

**Enjoy your ad-free Spotify experience with SpotifyAB!** 🎶🚀
