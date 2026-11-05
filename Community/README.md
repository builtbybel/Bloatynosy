# Community recipes

Explore shows two independent shelves: tweak packs add definitions; recipes select existing
definitions and apps. Downloading or previewing a recipe does not apply changes or install packs.

## Contributing

Submit a pull request with a recipe in `Recipes/` and an entry in `Recipes/index.json`:

```json
{
  "File": "my-recipe.json",
  "Name": "My recipe",
  "Author": "Your name",
  "Description": "What this selection does, including relevant tradeoffs."
}
```

Use a plain filename, not a URL or path. Files are fetched only from this repository's
`Community/Recipes/` directory. The list is curated through repository review, not an upload service.

The recipe itself uses the normal export format:

```json
{
  "Name": "My recipe",
  "Changes": [ { "Name": "Show File Extensions", "Reset": false } ],
  "Apps": []
}
```

Use exact INI section names, never translated display names. `Reset: true` requests a documented
default rather than the recommended value. `Apps` contains the identifiers used by normal recipe
exports. No registry paths, scripts or uninstall commands belong in a recipe.

Check the preview before submitting. Missing definitions, already satisfied changes, ignored
entries and protected apps are handled by the existing recipe review. Conflicting variants block
selection. Missing packs are never installed automatically.

The three starter recipes are authored by Belim. Copies ship with the application so Explore
remains useful offline, including before the online shelf is published. A status message identifies
this fallback. The index and recipe files always come from the same source for that session.

After confirming a preview, users can save the resulting selection through the existing
**Save recipe** action. This saves the selected outstanding changes, not an automatic subscription
to future community updates.

## Publishing

Commit `Recipes/index.json` and the listed JSON files to the repository's `main` branch. No service,
account system or separate deployment is required. Adding recipes then does not require a new EXE.
