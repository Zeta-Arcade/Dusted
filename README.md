# Dusted
Addon for WeatherRegistry to allow DustClouds weather to be added to any moon!

## Setup
Simply add the mod and load into a lobby to generate the config file. From there, you can specify moon names in a semicolon seperated list (e.g. Experimentation;Assurance;Offense;) to add the weather to the moon!

## Warning!
- You will run into issues if you remove the mod on an existing save where DustClouds has been added to a moon previously by the mod, as if thats the current weather now and you try to land there it will error.
- How moons will behave once DustClouds is added is out of my control, as its down to the dev of the moon to implement support for DustClouds *themselves* if its a weather THEY want on their moon. Any unintended behaviour from forcibly adding it this way is on you for choosing to do so with this mod. Likewise, its also possible the weather will do nothing on some moons boowomp.
- Since DustClouds are injected into the pool of weathers for a moon *after* WeatherRegistry finishes setting up the weather lists for the moon, DustClouds will not show up on the first day of using the mod on a save file. However once you enter orbit again after the first day with the mod enabled, DustClouds will then be able to start appearing on moons you have added it to in the config.
- I am gonna assume this mod + identical configs is required on both the server and client. It might work just server-only, but i wouldn't risk it personally!
- The mod was just intended for personal use in my modpack, i cannot guarantee any features or continued support!

## Credits
- [Mrov](https://thunderstore.io/c/lethal-company/p/mrov/) for basically writing all the initial code for it and helping me bug fix it and supporting me making it. Ty!!
