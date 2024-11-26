# Run as Admin
if (-not ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
{
    Write-Warning "You need to run this script as an Administrator!"
    exit
}

# Load Windows Forms assembly for MessageBox
Add-Type -AssemblyName System.Windows.Forms

# Define the restore point description and type
$description = "Bloatynosy NueEx Restore Point"
$restorePointType = 12  # MODIFY_SETTINGS = 12

# Function to create restore point with progress reporting
function Create-RestorePoint {
    Write-Host "Starting to create restore point..." -ForegroundColor Yellow
    
    # Simulate progress
    for ($i = 0; $i -le 100; $i += 10) {
        Write-Progress -Activity "Creating Restore Point" -Status "$i% Complete" -PercentComplete $i
        Start-Sleep -Milliseconds 300  # Simulate some work being done
    }

    # WMI query to create the restore point
    $restorePoint = Get-WmiObject -List Win32_SystemRestore | ForEach-Object {
        $_.CreateRestorePoint($description, $restorePointType, 100)
    }

    Write-Host "Restore point created successfully." -ForegroundColor Green
    
    # Show completion message
    [System.Windows.Forms.MessageBox]::Show("Restore point has been created successfully!", "Completion", [System.Windows.Forms.MessageBoxButtons]::OK, [System.Windows.Forms.MessageBoxIcon]::Information)
}

# Execute the restore point creation
Create-RestorePoint
