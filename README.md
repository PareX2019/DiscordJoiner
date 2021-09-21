# Discord Joiner

This discord joining method is like the one Synapse X and Dark Hub use, The RPC method.

## Usage

Create a file like [this](https://pip.pypa.io/en/stable/) one and place it where the 'here' is
```csharp
 new ASCIIEncoding().GetBytes(wc.DownloadString("here"));
```

In that file you will need to have this text right here:
```json
{
   "args" : {
      "code" : "invitecode"
   },
   "cmd" : "INVITE_BROWSER",
   "nonce" : "."
}
```
Replace 'invitecode' with the last characters of a discord invite url , For example:
This: **https://discord.gg/e8G2Np39d8**
would become this.
```json
{
   "args" : {
      "code" : "e8G2Np39d8"
   },
   "cmd" : "INVITE_BROWSER",
   "nonce" : "."
}
```
## Credits
Written by PareX, Feel free to dm me on discord if you think I could improve the code or anything in this repo
