# VelibLibrary
#### HUANG Xiaohan

### Arboréscence de la solution :
/VelibLibrary<br>
|<br>
+--- packages (contient les bibliothèques externes nécessaires à la solution, pour parser les JSON (.NET JSON newtonsoft))<br>
|<br>
+--- VelibClientWinform (client SOAP graphique)<br>
|<br>
+--- VelibClient (client SOAP en ligne de commande)<br>
|<br>
+--- VelibLibrary (service SOAP servant d'intermédiaire entre le client SOAP et l'API REST)<br>
|<br>
+--- VelibLibrary.sln (fichier .sln de la solution)<br>


### Axes choisis :

* MVP (Mark Scale : 10 points)
* Graphical User Interface for the client (Mark Scale : 2 points)
* Replace all the accesses to WS (beetween Velib WS and IWS, between IWS and WS Clients) with asynchronous ones. Some indications can be find just below. (Mark Scale : 3 points)
* Add a cache in IWS, to reduce communications between Velib WS and IWS (Mark Scale : 4 points)


### Utilisation :

* Application graphique, 3 valeurs sont attendues pour afficher le nombre de vélos disponibles.
1. La liste de ville
2. Le nom du ville.
3. Le nom de la station.
4. Cliquer sur le bouton de Recherche correspondant.
Si le ville et de la station n'est pas correcte, une fenêtre de notification vous présentera. 
Le cache du nombre de vélo de chaque station mis à jour si le temps dépasse 5 mins. 

* Application console.
1. help : affiche une description de ce application.
2. cities : affiche la liste des contrats disponibles.
3. demande le nom de ville, et affiche la liste des stations du contrat passé en paramètre.
4. demande le nom de station,et affiche le nombre de vélos disponibles aux stations contenant du contrat.
