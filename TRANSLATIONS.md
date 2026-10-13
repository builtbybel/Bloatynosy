# Translating Bloatynosy

A language is one file. No build, no pull request required to try it, no tooling to install.

Copy `Localization\en.json`, name it after your locale, translate the values. The app reads the
folder on every start, so your file shows up in **Settings → Display language** the next time you
open it.

```
Localization\
  en.json     the interface, and the file you copy
  de.json     an example of a finished one
  fr.json     yours
```

## Rules of the file

It is plain JSON in UTF-8. Three things decide whether it works:

- **Keys stay English.** Only the text on the right of the colon gets translated.
- **Placeholders stay.** `{0}`, `{1}` and `{app}` are filled in by the app. Move them inside the
  sentence if your language wants them elsewhere, but do not drop or rename them. A broken
  placeholder does not crash anything, the app falls back to the key, but the line will look wrong.
- **`_Language` is your language's own name**, written in that language. That is what the picker in
  Settings shows, so `Français`, not `French`.

A key you delete falls back to English, so an unfinished file is a usable file.

## Where the text actually comes from

This is the part that surprises people, and it is worth two minutes.

| | Lives in | How you translate it |
|---|---|---|
| Buttons, headings, hints, reports | `Localization\en.json` | copy the file, translate the values |
| Tweak names and descriptions | `Data\WinRules.ini` | optional extra keys in your file |
| App names | Windows itself | not translatable, they are what the system reports |

The tweak catalogue is a text file, not a resource table. Every section in `Data\WinRules.ini` is one
tweak, and its heading and `Description` line are the English original:

```ini
[Hide Search from Taskbar]
Category=Taskbar
Description=Removes the search from the taskbar completely, field and icon alike. Search still opens from the Start menu or with Win+S.
```

To translate that one, add two keys to your language file. The section heading is the key:

```json
"Tweak_Name_Hide Search from Taskbar": "Suche aus der Taskleiste nehmen",
"Tweak_Detail_Hide Search from Taskbar": "Entfernt die Suche vollständig aus der Taskleiste, Feld wie Symbol. Die Suche öffnet weiterhin über das Startmenü oder Win+S."
```

Both are optional and independent. Translate the name and leave the description, or the other way
round, and the missing half stays English.

### Why these keys are not in `en.json`

Because for English the app reads the ini directly. A second English copy next to it would be two
sources for one sentence, and the day somebody edits one of them, the app starts contradicting
itself. The ini wins, so the ini is the only place the English text is written down.

That is also why your file can be shorter than you expect and still be complete.

## Plugins

Any other `.ini` dropped into `Data\` is read as well. Its tweaks are translated exactly the same
way, because the key is the section name and nothing else. A plugin author can ship translations by
sending you the two lines per section, no matter which file the section came from.

## Keeping up

The catalogue grows. When a tweak appears that your file does not know, it simply shows up in
English, which is why nothing breaks between releases and why there is no deadline on any of this.

If you want a starting point with every current section already listed, open an issue and ask. A
skeleton can be generated from the ini in a second, so nobody has to copy headings by hand.

---

Back to the [README](README.md).
