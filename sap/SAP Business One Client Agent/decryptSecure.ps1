Add-Type -AssemblyName System.Security
$encrypted = $args[0]
$file = $args[1]

if (Test-Path $file) {
  Remove-Item $file
}
Try {
    $encryptedBytes = [System.Convert]::FromBase64String($encrypted)
    $decrypted = [Security.Cryptography.ProtectedData]::Unprotect( $encryptedBytes, $null, [Security.Cryptography.DataProtectionScope]::LocalMachine );
    $pass = [System.Text.Encoding]::UTF8.GetString($decrypted)
	$pass = $pass -replace "`0", ""
}
Catch {
    return;
}
$pass | Out-File -FilePath $file