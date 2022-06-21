# TRN-Getting-CS-GO-statistics

**RU**: Получение данных с сайта tracker.gg по игре CS:GO через HTTP запрос, на вход получаем Json файл, с помощью Newtonsoft десерилизуем Json в C# Класс. 
Возможно десерилизовать как по отдельности, так и всю статистику одновременно.

</br>Для десерилизации только статистики карт - используйте метод ```GetMapsStats()```
</br>Для десерилизации только оружия - используйте метод ```GetWeaponsStats()```
</br>Для десерилизации только статистики провиля - используйте метод ```GetProfileStats()```
</br>Для получения всей статистике - используйте метод ```AllStatistics()```

**EN**:
Retrieving data from the site tracker.gg on the game CS:GO via HTTP request, we get a Json file as input, using Newtonsoft we deserialize Json into C# Class.
It is possible to deserialize both individually and all statistics at the same time.

</br>To deserialize only map statistics - use the ```GetMapsStats()``` method
</br>To deserialize weapons only, use the ```GetWeaponsStats()``` method
</br>To deserialize profile statistics only - use the ```GetProfileStats()``` method
</br>To get all statistics - use the ```AllStatistics()``` method
