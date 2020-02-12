# HololensArtifact

## Testing Unity Scenes with Hololens

<h3>Step 1</h3>

<b>Open "Holographic Remoting Player" on the Hololens</b>

<h3>Step 2</h3>

<b>Copy the IP address into the address bar of "Window > XR > Holographic Emulation" and connect</b>

<h3>Step 3</h3>

<b>
  Build and delpoy with these settings
  <ul>
    <li>Target Device - HoloLens </li>
    <li>UWP Build Type - D3D</li>
    <li>UWP SDK - Latest Installed</li>
	<li>MinVersionTested="10.0.10586.0"</li>
    <li>Check "Unity C# Projects" under Debugging</li>
  </ul>
  Build
</b>

<h3>Step 4</h3>

<b> Visual Studio, change Debug to Release, ARM to X86</b>

<h3>Step 5</h3>

<b>Click on the arrow next to the Local Machine button, and change the deployment target to Remote Machine.</b>
<b>Set the IP address same as Hololens, Authemtication Mode to Universal (Unencypted protocal)</b>
<b>Debug - Start Without Debugging</b>

<h2>For full and thoughra instructions, follow: <a href="https://docs.microsoft.com/en-us/windows/mixed-reality/holograms-100">docs.microsoft.com/en-us/windows/mixed-reality/holograms-100</a></h2>
