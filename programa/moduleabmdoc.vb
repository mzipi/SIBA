Module moduleabmdoc
    Enum acciones
        ingresar = 0
        modificar
        eliminar
    End Enum
    Public accion As acciones
    Structure docentes
        Dim ci As String
        Dim nombre_completo As String
        Dim grado As String
        Dim antiguedad As Integer
        Dim form_acad As String
        Dim tel As String
        Dim categoria_docente As String

    End Structure
    Structure bajadocente

        Dim baja_desde As String
        Dim ci As String
        Dim idg As Integer
        Dim cod_materia As String
        Dim motivo As String
        Dim estado_funcional As String
        Dim nombre_docente As String
        Dim estado As String
        Dim grupo As String
        Dim nombre_mat As String

    End Structure
    Structure carreras
        Dim nombre_carr As String
        Dim duracion As String

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
        Dim nombre_turno As String
        Dim id_turno As Integer

    End Structure
    Structure se_divide
        Dim id_horas As Integer
        Dim id_turno As Integer
    End Structure
    Structure turno
        Dim id_turno As Integer
        Dim nom_turno As String
    End Structure
    Structure usuarios
        Dim nombre_usuario As String
        Dim contraseña As String
        Dim ced_id As Integer
        Dim perfil_usuario As String
        Dim email As String
        Dim nombre_apellido As String

    End Structure
    Structure planilla
        Dim titulo As String

    End Structure
    Structure materia
        Dim cod_materia As String
        Dim carga_horaria As Integer
        Dim nombre_mat As String
        Dim tipo_mat As String
        Dim nombre_carr As String
        Dim año_mat As String




    End Structure
    Public planillado As planilla
   
    Public unamateria As materia
    Public undocente As docentes
    Public unacarrera As carreras
    Public ungrupo As grupos
    Public unsalon As salon
    Public unahora As horas
    Public asighora As se_divide
    Public unturno As turno
    Public unusuario As usuarios
    Public bajadoc As bajadocente
End Module