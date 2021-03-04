Module moduleabmdoc
    Enum acciones
        ingresar = 0
        modificar
        eliminar
    End Enum
    Public accion As acciones
    Structure docentes
        Dim ci As Integer
        Dim nombre_completo As String
        Dim grado As String
        Dim antiguedad As Integer
        Dim form_acad As String
        Dim tel As String
        Dim estado_funcional As String
        Dim vac_desde As Date
        Dim vac_hasta As Date

    End Structure
    Structure carreras
        Dim nombre_carr As String
        Dim duracion As Integer

    End Structure
    Structure grupos
        Dim idg As Integer
        Dim anio As Integer
        Dim curso As String
        Dim letra As String
        Dim id_turno As Integer
        Dim nombre_carr As String
    End Structure
    Structure salon
        Dim cod_salon As Integer
        Dim tipo_salon As String
        Dim num_salon As Integer

    End Structure
    Structure horas
        Dim id_horas As Integer
        Dim num_horas As Integer
        Dim dia As String
        Dim inicio As Date
        Dim fin As Date
        Dim validar As Boolean

    End Structure
    Structure se_divide
        Dim id_horas As Integer
        Dim id_turno As Integer
    End Structure
    Structure TURNO
        Dim id_turno As Integer
        Dim nom_turno As String

    End Structure
    Public undocente As docentes
    Public unacarrera As carreras
    Public ungrupo As grupos
    Public unsalon As salon
    Public unahora As horas
    Public asighora As se_divide
    Public unturno As TURNO

End Module