# Inplace Upgrade via Server Setup. (Current release: Windows 11 2024 Update l Version 24H2)
# This method leverages the Windows Server variant of the Windows setup, which skips most hardware compatibility checks. It allows Windows 11 to be installed on unsupported PCs, bypassing the usual system requirements. Importantly, while the setup runs in server mode, it installs the standard Windows 11 (not the server version).


# Function to open a file selection dialog and return the selected file path
function Select-ISOFile {
    Add-Type -AssemblyName System.Windows.Forms
    $fileDialog = New-Object System.Windows.Forms.OpenFileDialog
    $fileDialog.Filter = "ISO Files (*.iso)|*.iso"
    $fileDialog.Title = "Select an ISO File"
    $fileDialog.InitialDirectory = [Environment]::GetFolderPath("Desktop")  # Start at Desktop

    if ($fileDialog.ShowDialog() -eq [System.Windows.Forms.DialogResult]::OK) {
        return $fileDialog.FileName
    } else {
        return $null
    }
}

# Prompt user to select an ISO file
$isoFilePath = Select-ISOFile

if (-not $isoFilePath -or -not (Test-Path $isoFilePath)) {
    Write-Host "No valid ISO file selected. Exiting." -ForegroundColor Red
    exit
}

Write-Host "Selected ISO file: $isoFilePath" -ForegroundColor Green
Write-Host "Mounting the ISO..." -ForegroundColor Blue

# Mount the ISO file
try {
    Mount-DiskImage -ImagePath $isoFilePath
    Write-Host "ISO mounted successfully." -ForegroundColor Green
} catch {
    Write-Host "Failed to mount the ISO. Error: $_" -ForegroundColor Red
    exit
}

# Retrieve the drive letter of the mounted ISO
$mountedVolume = Get-Volume | Where-Object { $_.DriveType -eq 'CD-ROM' -and $_.FileSystemLabel -ne $null } | Select-Object -First 1

if (-not $mountedVolume) {
    Write-Host "Failed to find mounted drive. Exiting." -ForegroundColor Red
    exit
}

$driveLetter = $mountedVolume.DriveLetter + ":"
Write-Host "Mounted drive letter: $driveLetter" -ForegroundColor Green

# Check for the Sources folder
$sourcesFolderPath = Join-Path -Path $driveLetter -ChildPath "sources"
if (-not (Test-Path $sourcesFolderPath)) {
    Write-Host "Sources folder not found at $sourcesFolderPath. Exiting." -ForegroundColor Red
    exit
}

Write-Host "Sources folder found at $sourcesFolderPath" -ForegroundColor Green

# Create the path to the setup file
$setupFile = Join-Path -Path $sourcesFolderPath -ChildPath "setupprep.exe"

# Ensure $setupFile is a valid string
if (-not (Test-Path $setupFile)) {
    Write-Host "setupprep.exe not found in Sources folder. Exiting." -ForegroundColor Red
    exit
}

Write-Host "Launching Windows setup. Path: $setupFile" -ForegroundColor Blue

# Launch the setup process
try {
    Start-Process -FilePath $setupFile -ArgumentList "/product server" -NoNewWindow
    Write-Host "Windows setup launched successfully. Follow the instructions on the screen." -ForegroundColor Green
} catch {
    Write-Host "Error launching Windows setup: $_" -ForegroundColor Red
}
