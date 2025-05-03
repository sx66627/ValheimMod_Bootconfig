using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using BepInEx;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

[BepInPlugin("sx66627.bootconfig", "BootConfig", "0.1")]
public class BootConfigModifier : BaseUnityPlugin
{
    private void Awake()
    {
        try
        {
            // Путь к файлу boot.config
            string bootConfigPath = Path.Combine(UnityEngine.Application.dataPath, "boot.config");

            // Если файла нет, создаем его
            if (!File.Exists(bootConfigPath))
            {
                File.Create(bootConfigPath).Close();
            }

            // Считываем текущие строки из файла
            List<string> lines = File.ReadAllLines(bootConfigPath).ToList();

            // Создаем словарь для хранения текущих параметров
            Dictionary<string, string> configEntries = new Dictionary<string, string>();
            foreach (var line in lines)
            {
                var match = Regex.Match(line, @"^(.*?)=(.*)$");
                if (match.Success)
                {
                    configEntries[match.Groups[1].Value.Trim()] = match.Groups[2].Value.Trim();
                }
            }

            // Определяем количество потоков процессора
            int threadCount = Environment.ProcessorCount;

            // Задаем новые значения для параметров
            configEntries["gfx-enable-gfx-jobs"] = "1";
            configEntries["gfx-enable-native-gfx-jobs"] = "1";
            configEntries["scripting-runtime-version"] = "latest";
            configEntries["wait-for-native-debugger"] = "0";
            configEntries["vr-enabled"] = "0";
            configEntries["hdr-display-enabled"] = "0";
            configEntries["gc-max-time-slice"] = threadCount.ToString();

            // Формируем обновленный список строк
            List<string> updatedLines = new List<string>();
            foreach (var entry in configEntries)
            {
                updatedLines.Add($"{entry.Key}={entry.Value}");
            }

            // Записываем обновленные строки обратно в файл
            File.WriteAllLines(bootConfigPath, updatedLines);

            Logger.LogInfo("boot.config updated successfully.");
        }
        catch (Exception ex)
        {
            Logger.LogError($"Error while processing boot.config: {ex.Message}");
        }
    }
}