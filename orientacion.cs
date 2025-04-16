using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientacion : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string orientaciónAlumno;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "" || añoAlumno < 1 || añoAlumno > 5)
        {
            Debug.Log("El nombre o año del alumno es inválido.");
        }
        else if (orientaciónAlumno != "T" && orientaciónAlumno != "D" && orientaciónAlumno != "G" && orientaciónAlumno != "M" && orientaciónAlumno != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else if (añoAlumno != 3 && añoAlumno != 4 && añoAlumno != 5)
        {
            Debug.Log("Error.Aún estás en el ciclo básico");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
