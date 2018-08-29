Partial Class TeatroDataSet
    

   

    Partial Class PAGOEFECTIVODataTable

        Private Sub PAGOEFECTIVODataTable_PAGOEFECTIVORowChanging(ByVal sender As System.Object, ByVal e As PAGOEFECTIVORowChangeEvent) Handles Me.PAGOEFECTIVORowChanging

        End Sub

    End Class

    Partial Class VENTASVENDEDORDataTable

    End Class

    Partial Class VENTASVENDEDORESDataTable

    End Class

    Partial Class VENTASDIARIASDataTable

    End Class

    Partial Class EVENTOSDataTable

        Private Sub EVENTOSDataTable_EVENTOSRowChanging(ByVal sender As System.Object, ByVal e As EVENTOSRowChangeEvent) Handles Me.EVENTOSRowChanging

        End Sub

    End Class

    Partial Class VENTASENTRADASDataTable

    End Class

    Partial Class PRODUCCIONDataTable

    End Class

    Partial Class VENDEDORESDataTable

        Private Sub VENDEDORESDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.APELLIDOVENDEDORColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class EMPLEADOSDataTable

    End Class

End Class
