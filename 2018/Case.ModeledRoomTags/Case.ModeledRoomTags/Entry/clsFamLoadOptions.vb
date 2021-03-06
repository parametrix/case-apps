﻿Imports Autodesk.Revit.DB

Namespace Entry

  Public Class clsFamLoadOptions

    Implements IFamilyLoadOptions

    ''' <summary>
    ''' What to do on a Found Family 
    ''' </summary>
    ''' <param name="familyInUse"></param>
    ''' <param name="overwriteParameterValues"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OnFamilyFound(familyInUse As Boolean,
                                  ByRef overwriteParameterValues As Boolean) _
      As Boolean Implements IFamilyLoadOptions.OnFamilyFound

      ' Overwrite Data?
      'overwriteParameterValues = True

      Return True

    End Function

    ''' <summary>
    ''' What to do on a Found Shared Family
    ''' </summary>
    ''' <param name="sharedFamily"></param>
    ''' <param name="familyInUse"></param>
    ''' <param name="source"></param>
    ''' <param name="overwriteParameterValues"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function OnSharedFamilyFound(sharedFamily As Autodesk.Revit.DB.Family,
                                        familyInUse As Boolean,
                                        ByRef source As FamilySource,
                                        ByRef overwriteParameterValues As Boolean) _
      As Boolean Implements IFamilyLoadOptions.OnSharedFamilyFound

      Return True

    End Function

  End Class
End Namespace