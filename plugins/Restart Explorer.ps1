# Function to show a message box
function Show-MessageBox {
    param (
        [string]$message,
        [string]$title = "Information"
    )
    Add-Type -AssemblyName PresentationFramework
    [System.Windows.MessageBox]::Show($message, $title)
}

# Stop Windows Explorer
Stop-Process -Name explorer -Force

# Start Windows Explorer
Start-Process explorer

# Show message box
Show-MessageBox -message "Windows Explorer has been restarted successfully." -title "Bloatynosy NueEx"
