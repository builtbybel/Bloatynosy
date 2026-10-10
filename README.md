<div align="center">

# Bloatynosy Origin

**Open the app, see what Windows is doing, decide for yourself what stays.**

[![Release](https://img.shields.io/github/v/release/builtbybel/Bloatynosy?style=flat-square)](https://github.com/builtbybel/Bloatynosy/releases)
![Windows](https://img.shields.io/badge/Windows-10%20%7C%2011-0078D4?style=flat-square)

</div>

<!-- TODO: showcase image -->

## I gave up on this app more than once

The classic Bloatynosy got renamed, then discontinued. Winpilot replaced it and did not last.
Everything I built after that added more and solved less. [None of it ever beat version 0.85](https://github.com/builtbybel/Bloatynosy/releases/tag/0.85.0), which
was one window, a list, and a button.

I kept taking the app in new directions. New names, new interfaces, new ideas. Some of those
experiments were fun, but every one of them moved further away from the thing that made the first
version worth using. Honestly, I should never have let that idea go.

Nobody else was going to bring it back, so I did. That is what **Origin** means. Not a sequel, not a
fork, not version 12. It is me going back to the version that worked and building that one properly.

The king is back. This time, he came home. 👑

---

## Install

Grab the latest build from the [Releases page](https://github.com/builtbybel/Bloatynosy/releases),
extract it somewhere you can write to, run `Bloatynosy.exe`. That's it, it's portable.

Needs Windows 10 or 11 and .NET Framework 4.8.

Some machine wide settings can only be written with administrator rights. Bloatynosy does not demand
them up front. It runs as you, and if Windows refuses a change, the report says so and names the
setting. Start it as administrator if you want those included.

---

## Using it

Three steps, and the app shows you which one you are on.

| | |
|---|---|
| **1** | **Check your PC.** Bloatynosy reads settings and installed apps. Nothing is changed while it looks |
| **2** | **Review the results.** Tick what should go, untick what you want to keep |
| **3** | **Apply the changes.** A report tells you what worked, what did not, and what needs a restart |

The results are a tree, not 300 flat checkboxes. **Available changes** are the ones that still need
work. **Already applied** holds everything that is set the way the list recommends, so you can pick
from there if you want a setting back. **Installed apps** is its own group.

Pick a row and the bottom of the window explains it in plain words. **Show details** adds the
technical side, the actual registry path and value, for when you want to know exactly what happens.

### Putting things back

Settings that carry a documented default can be reset. Select them in **Already applied** and the
button changes from "Apply" to "Reset".

> [!IMPORTANT]
> Removed Store apps are the exception. Windows has no real undo for an uninstall, so reinstalling
> means going through the Store.

### Apps

Apps are never ticked for you. Bloatynosy sorts them into bloatware candidates, personal choices,
and components Windows needs, and the last group cannot be selected at all. Uninstalling asks once
more before it starts, because removing an app is a different decision from changing a setting.

---

## Under the hood

<details>
<summary><b>What Bloatynosy actually changes</b></summary>

Every setting in the list writes one documented or well known registry value. The app does not patch
system files, does not stop services, and there is no mystery "Optimize" button that runs a script
nobody can read.

A value is checked before it is written, and read back after. If the readback does not match, the
setting counts as failed and lands in the report instead of silently pretending to have worked.

Installed apps are removed through Windows PowerShell with `Remove-AppxPackage`. Packages that
Windows marks as non removable, as a framework, or as a resource package are refused.

</details>

<details>
<summary><b>The tweak list, and how plugins work</b></summary>

Everything Bloatynosy knows lives in [`Data/Tweaks.ini`](Data/Tweaks.ini). One section is one
setting: where it lives, what value applies it, what value puts it back, which category it belongs
to and whether it should be ticked by default.

Any other `.ini` file you drop next to it in `Data\` is read as well. That is the entire plugin
system. No DLL to compile, no manifest, no API. A section whose name already exists replaces the one
before it, so a plugin can correct one of my entries instead of only adding new ones. A file that
cannot be read is one missing plugin, not a crash.

App handling has its own file, [`Data/AppRules.ini`](Data/AppRules.ini), which decides what counts as
a bloatware candidate and what Windows is not allowed to lose. It is the one `.ini` in the folder
that is not read as a tweak file.

**Settings → Open the folder with the change catalogue** takes you straight there.

</details>

<details>
<summary><b>Every field a tweak section can carry</b></summary>

The section heading is the name of the tweak and has to be unique. Blank lines are ignored, a line
starting with `;` is a comment, and a comment may also sit behind a value when a space comes first.

| Key | Meaning |
|---|---|
| `Category` | Which group the tweak is listed under: `Ads`, `AI`, `Appearance`, `Edge`, `Gaming`, `Privacy`, `System`, `Taskbar`, `Updates`. An unknown name shows as the raw key |
| `Description` | The plain words shown under the list when the row is selected |
| `Restart` | `explorer` or `system` when the change is only visible afterwards. The report collects these, each one once. Leave it out when the change takes effect right away |
| `OsVersion` | `11` for Windows 11 only, `10` for Windows 10 only. Left out means both |
| `DefaultSelected` | `true` ticks the tweak after a check, as long as no profile is chosen |
| `Path` | The full registry path including the hive, for example `HKEY_CURRENT_USER\Software\...` |
| `ValueName` | The value to write. `(Default)` writes the key's unnamed value |
| `ValueType` | `DWORD` or `String`. Left out means `DWORD` |
| `RecommendedValue` | What applying the tweak writes. The check compares the value on the pc against this one |
| `DefaultValue` | What resetting writes. Without it the tweak cannot be put back. `<delete>` or `<deletevalue>` removes just that one value and leaves the rest of the key alone |

One tweak can write several values. The second one uses `Path2`, `ValueName2`, `ValueType2`,
`RecommendedValue2` and `DefaultValue2`, the third one `Path3`, and so on. The numbering stops at the
first missing `Path` or `ValueName`. A tweak is applied only when every one of its values can be
written, so a tweak that needs two keys never ends up half done.

A section without a single usable value is skipped. Paths under `HKEY_LOCAL_MACHINE`,
`HKEY_CLASSES_ROOT` or anything containing `\Policies\` need administrator rights, and the app says
so instead of trying and failing quietly.

Names and descriptions can be translated. A locale file entry `Tweak_Name_<section>` replaces the
heading and `Tweak_Detail_<section>` replaces the description.

</details>

<details>
<summary><b>Profiles</b></summary>

A profile is a plain JSON file holding the names of the tweaks and the families of the apps that a
check should tick by itself.

```json
{
  "Name": "Workshop",
  "Tweaks": ["Disable Start Menu Ads", "Disable Tips and Suggestions"],
  "Apps": ["Microsoft.BingWeather"]
}
```

Choose one under **Settings → Profile** and the path is remembered, so it survives a restart. Without
a profile the catalogue decides, which is what `DefaultSelected` has always meant.

The report offers **Save this pc as a profile** when a run is finished. Hand the file to the next
machine and the check arrives ticked.

The tweak list is the state the pc reached, not what that one run happened to change, so a profile
taken from an already clean machine still names every setting. The app list can only hold what that
run uninstalled: Windows lists installed packages, so an app that was gone beforehand is invisible to
the inventory and cannot be written down.

</details>

<details>
<summary><b>Optional AI explanations</b></summary>

**Explain** can ask an AI provider for a short second opinion about the selected entry. It is off
until you turn it on in Settings and add your own API key. Groq, OpenAI, Anthropic and any
OpenAI compatible endpoint work.

Without it the app is completely local. When you do ask, only the name and technical details of that
one entry are sent, never a scan of your PC.

</details>

<details>
<summary><b>The old source</b></summary>

The code behind every version up to the discontinued one sits in [`legacy/`](legacy). It is kept for
the record and is not maintained. Origin shares no code with it.

</details>

---

## Still early

Windows moves things around with every build, and a value that works today can be ignored tomorrow.
If a setting does not stick on your machine, or Bloatynosy reports a failure you do not understand,
please [open an issue](https://github.com/builtbybel/Bloatynosy/issues) and say which Windows version
you are on. That helps more than me guessing.

An app icon is still missing and there is polish left to do. It is coming.
