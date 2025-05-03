<div style="text-align: center;">

![logo](http://xdw.su/icon.png "Title")

</div>

# Valheim BootConfig Mod

## :us: English

### Introduction
I decided to publish this source because it was unfairly [removed](https://www.nexusmods.com/valheim/mods/3046) from the Nexusmods.com portal.
With the reason that I used someone else's asset. But this is not true, the code was completely written by me. And there are no similar mods on this portal.

View all my mods: https://next.nexusmods.com/profile/sx66627/mods

### Description
Creates or modifies the valheim_Data/boot.config file to improve performance.

What it writes to the file:
```ini
gfx-enable-gfx-jobs=1
gfx-enable-native-gfx-jobs=1
scripting-runtime-version=latest
wait-for-native-debugger=0
vr-enabled=0
hdr-display-enabled=0
gc-max-time-slice=28 (Determines the number of threads of your processor and sets an equal value)
```

**Values ​​that were already in the file are not deleted!** If there were already such records in the file, then their value is replaced.


### Installation
- Install [BepInEx](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/) (if you have installed BepInEx for other mods like Valheim Plus you can skip this step).

- Download the mod (ValheimMod_Bootconfig.zip) and unpack its contents into .../Valheim/BepInEx/plugins

- Done


### How it works
When you first load, the data will be written.
After you restart the game, it will be applied.

---
## :ru: Русский

### Введение
Я решил опубликовать этот исходник, потому что он был несправедливо [удален](https://www.nexusmods.com/valheim/mods/3046) с портала Nexusmods.com.
По той причине, что я использовал чужой asset. Но это неправда, код полностью написан мной. И на этом портале нет похожих модов.

Посмотреть все мои моды: https://next.nexusmods.com/profile/sx66627/mods

### Описание
Создает или изменяет файл valheim_Data/boot.config для повышения производительности.

Что он пишет в файл:
```ini
gfx-enable-gfx-jobs=1
gfx-enable-native-gfx-jobs=1
scripting-runtime-version=latest
wait-for-native-debugger=0
vr-enabled=0
hdr-display-enabled=0
gc-max-time-slice=28 (Определяет количество потоков вашего процессора и устанавливает равное ему значение)
```

**Значения, которые уже были в файле, не удаляются!** Если в файле уже были такие записи, то их значение заменяется.

### Установка
- Установите [BepInEx](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/) (если вы установили BepInEx для других модов, таких как Valheim Plus, вы можете пропустить этот шаг).

- Загрузите мод (ValheimMod_Bootconfig.zip) и распакуйте его содержимое в .../Valheim/BepInEx/plugins

- Готово

### Как это работает
При первой загрузке данные будут записаны.
После перезапуска игры они будут применены.
