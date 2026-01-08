# How to Remove the Columns Border in UWP DataGrid?

This example illustrates how to remove the columns border in [UWP DataGrid](https://www.syncfusion.com/uwp-ui-controls/datagrid) (SfDataGrid).

By default, `DataGrid` having gird lines for each row and column. But we can remove the grid lines for the default row by write style for `BorderThickness` property of [GridCell](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.GridCell.html) and remove the grid lines for Header row by write style for `BorderThickness` property of [GridHeaderCellControl](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.GridHeaderCellControl.html) and [GridHeaderIndentCell](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.GridHeaderIndentCell.html). 

#### XAML
``` xml
<Page.Resources>        
        <Style TargetType="syncfusion:GridCell">
            <Setter Property="BorderThickness" Value="0,0,0,0" />            
        </Style>
        <Style TargetType="syncfusion:GridHeaderCellControl">            
            <Setter Property="BorderThickness" Value="0,0,0,0" />            
        </Style>
        <Style TargetType="syncfusion:GridHeaderIndentCell">           
            <Setter Property="BorderThickness" Value="0,0,0,0" />
        </Style>
</Page.Resources>
```

The following screenshot shows columns border removed in `DataGrid`.

![shows the column border removed in SfDataGrid](ColumnBorderRemovedinSfDataGrid.png)

## Requirements to run the demo
Visual Studio 2015 and above versions