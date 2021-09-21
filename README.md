# Discord Joiner

A light weight discord joiner that is only 5kb, This type of joiner can be written in any language and any environment that has web utility , Request example:
```
POST /rpc?v=1 HTTP/1.1
origin: https://discord.com
Content-Type: application/json
Host: 127.0.0.1:6463
Expect: 100-continue
Connection: Keep-Alive
Content-Length: 102

{
   "args" : {
      "code" : "e8G2Np39d8"
   },
   "cmd" : "INVITE_BROWSER",
   "nonce" : "."
}

```
All you need to do this in another language is just make a request like this.

## Usage

Create a file like [this](https://github.com/PareX2019/DiscordJoiner/blob/main/invite.txt) one and place it where the 'here' is
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
