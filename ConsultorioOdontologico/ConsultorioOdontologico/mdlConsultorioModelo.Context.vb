﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class consultorioEntity
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=consultorioEntity")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Alergias() As DbSet(Of Alergia)
    Public Overridable Property DetalleFacturas() As DbSet(Of DetalleFactura)
    Public Overridable Property Enfermedades() As DbSet(Of Enfermedade)
    Public Overridable Property EnfermedadesXPacientes() As DbSet(Of EnfermedadesXPaciente)
    Public Overridable Property Especialidads() As DbSet(Of Especialidad)
    Public Overridable Property EstadoTurnos() As DbSet(Of EstadoTurno)
    Public Overridable Property Facturas() As DbSet(Of Factura)
    Public Overridable Property HistoriaClinicas() As DbSet(Of HistoriaClinica)
    Public Overridable Property Medicamentos() As DbSet(Of Medicamento)
    Public Overridable Property MedicosXEspecialidads() As DbSet(Of MedicosXEspecialidad)
    Public Overridable Property ObraSocials() As DbSet(Of ObraSocial)
    Public Overridable Property ObraSocialXPacientes() As DbSet(Of ObraSocialXPaciente)
    Public Overridable Property Odontologos() As DbSet(Of Odontologo)
    Public Overridable Property Pacientes() As DbSet(Of Paciente)
    Public Overridable Property Planes() As DbSet(Of Plane)
    Public Overridable Property Prestaciones() As DbSet(Of Prestacione)
    Public Overridable Property PrestacionesPorPlans() As DbSet(Of PrestacionesPorPlan)
    Public Overridable Property Recetas() As DbSet(Of Receta)
    Public Overridable Property TipoDientes() As DbSet(Of TipoDiente)
    Public Overridable Property Turnoes() As DbSet(Of Turno)
    Public Overridable Property Ubicacions() As DbSet(Of Ubicacion)

End Class
