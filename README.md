# Voice SDK Unreal Samples

This is a demo game for Voice SDK. It demonstrates how to add Voice Commands and TTS into an Unreal game.  In the game user can use Voice Commands to change objects' color.

## Supported Engine Versions:

UE4.27, UE5.0 and UE5.1.

## Getting Started

  !["guide"](readme_images/guide.gif)

- Create a wit.ai app:

  - Download our app backup file from [here](https://github.com/wit-ai/voicesdk-unreal/releases/download/v47.0.4/wit_app_shapes_demo-2023-01-18-11-12-27.zip).

  - Visit [Wit.ai](https://wit.ai/apps) and create a new app with the backup file.

  !["Screengrab of creating a new Wit.ai app from a backup file"](readme_images/create-wit-app-from-a-backup.png)

- [Download](https://github.com/wit-ai/voicesdk-unreal-samples/archive/refs/heads/main.zip) this project

- Run `install_VoiceSDK.bat` to download and install Voice SDK (from Github) into the Plugins folder.

- Double click `voicesdk_unreal_demo.uproject` to open the project

- The first time you run this project, Unreal will need to compile Voice SDK, it will pop a window: `Missing voicesdk_unreal_demo Moduels`, then click `Yes` to compile Voice SDK.

- Once Unreal editor opened, then open the `ShapeConfiguration` file from `Content/VoiceSDK/Demo/Configuration` and put your Wit.ai's `Server Access Token` and `Client Access Token` there. Tokens can be found here:

  !["Screengrab of Wit.ai app's tokens"](readme_images/wit-tokens.png)

- `Play` the game and now you can try our magic: `Make the cube red`

  - You can use the input box to give a text command (e.g. `Make the cube red`) and then click the `Send` button to execute

  - Or click the `Acitvate` button to give a voice command.

## Marketplace

The above guide is the easiest way to setup the project, but if you prefer to download Voice SDK from Marketplace(you will not need to compile the plugin), please follow the below steps:

- Install the plugin from [Marketplace](https://www.unrealengine.com/marketplace/en-US/product/voice-sdk)

- Enable the Plugin:

  - Unreal Editor-> Settings-> Plugins-> Installed -> Voice -> VoiceSDK

  - Tick the checkbox to enable the plugin (Editor restart is needed)

- Add Voice to GameEngine.ini

Add the lines below to your game's Config/DefaultEngine.ini: (Editor restart is needed)

```
[Voice]
bEnabled=True
```

Note: the above steps only install Voice SDK, you still need to create the Wit.ai app and copy over tokens to the `ShapeConfiguration` file.

## License

The license for `voicesdk-unreal-samples` can be found in [LICENSE](https://github.com/wit-ai/voicesdk-unreal-samples/blob/main/LICENSE) file in the root directory of this source tree.

You can also find the applicable Oculus License here: https://developer.oculus.com/licenses/oculussdk

The MIT license applies to only certain, clearly marked documents. If an individual file does not indicate which license it is subject to, then the Oculus License applies.

## Terms of Use

Our terms of use can be found at https://opensource.facebook.com/legal/terms.

Use of Wit.ai services fall under the terms of use of Wit.ai found here: https://wit.ai/terms.

## Privacy Policy

Our privacy policy can be found at https://opensource.facebook.com/legal/privacy.

The privacy policy for the Wit.ai service can be found at https://wit.ai/privacy.