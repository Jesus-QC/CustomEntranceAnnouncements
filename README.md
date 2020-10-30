# CustomEntranceAnnouncements
 An EXILED SCP:SL Plugin that uses VirtualBrightPlayz/CommsHack ASS Plugin to Replace MTF and CHAOS entrance music with a custom one
 
# Installation
Download the .dll file of the latest release and place it inside the Exiled Plugins folder
And make sure to have installed VirtualBrightPlayz/CommsHack plugin too

# Configs
```yaml
EntranceMessages:
  # Is the plugin enabled?
  is_enabled: true
  # Is the mtf sound enabled?
  is_m_t_f_enabled: true
  # Name of the mp3 of mtf entry sound file inside Plugins/CustomEA
  m_t_f_entrance_audio_path: mtfentrance.mp3
  # Volume of MTFEntranceSound
  m_t_f_entrance_volume: 0.25
  # Is the chaos sound enabled?
  is_chaos_enabled: true
  # Name of the mp3 of chaos entry sound file inside Plugins/CustomEA
  chaos_entrance_audio_path: chaosentrance.mp3
  # Volume of ChaosEntranceSound
  chaos_entrance_volume: 0.75
```
