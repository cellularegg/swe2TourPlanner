# swe2_tour_planner


## ToDo
* DAL überlegen bis zum nächsten Mal für Feedback
* async?



## Notes
* https://www.youtube.com/watch?v=N26C_Cq-gAY&t=454s
* Wer macht was im MVVM: https://www.youtube.com/playlist?list=PL5I0mJDB37i80IfjquADX-ioSrZ3BHPxz  
* CI/CD als zusatzsfeature?
  * 
* Mehrere View Models für die verschiedenen masken (nicht nur eine MainViewModel -> bereiche als 
  User control -> mediator DP)
* Value converter für Textausgabe
* Layer architektur: UI (XAML) - UI (View Models) - Business Layer - Data access layer
* Data Access Layer:
  * Generisches Interface soll die Art und weise der Datenspeicherung abstrahieren
  * GetAllTours() -> interne SQL Query und returned Liste mit Objekten
  * parameter escapen -> keine SQL Query als param
  * Daten selbst im BL speichern (in Memory)
  * Singleton vlt
  

## Zusatzfeature Ideen:
* Config File Editor GUI
* CI/CD Pipline
* Erweiterte Suchfunktion (-, &&, ||, ...)
* 