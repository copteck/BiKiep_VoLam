

var data_return = [];





window.count_data = function (data_p1) {

    $('#html_data').html(data_p1);

    var data_return_items = [];
    var sott = $('.box_content').find('.next-page').find('a:last-child').html();



    var data = $('#html_data').find('ul.hsdn').html();
    $('#html_data').find('ul.hsdn li').each(function (_data) {

    
        var data_items = $(this);
        var ten_cty = data_items.find('h3').find('a').html();

        var masothue = data_items.find('div').find('a').html();

        var elemnt_diachi = data_items.find('div').html();

        var data_diachi_re = elemnt_diachi.replace("<em>Địa chỉ:</em>", "");
        var index = data_diachi_re.toString().indexOf("br");

        if (index > 0)
        {
            var diachi = data_diachi_re.toString().substr(0, index - 1);
            $('#html_ketqua').append(ten_cty);
            $('#html_ketqua').append("<br />");
            $('#html_ketqua').append(diachi);
            $('#html_ketqua').append("<br />");
            $('#html_ketqua').append(masothue);
            $('#html_ketqua').append("<hr>");
            data_return.push({ 'ten': ten_cty, 'diachi': diachi, 'mst': masothue });

        }


    });
    
    return { 'count_page': parseInt(sott), 'lst': data_return };

}










window.getdata = function (data_p1)
{

    $('#html_data').html(data_p1);

    var sott = $('.box_content').find('.next-page').find('a:last-child').html();
     
    var data = $('#html_data').find('ul.hsdn').html();
    $('#html_data').find('ul.hsdn li').each(function (_data) {

        /*$('#html_data').html($(this).html());*/
        var data_items = $(this);
        var ten_cty = data_items.find('h3').find('a').html();

        var masothue = data_items.find('div').find('a').html();

        var elemnt_diachi = data_items.find('div').html();

        var data_diachi_re = elemnt_diachi.replace("<em>Địa chỉ:</em>", "");
        var index = data_diachi_re.toString().indexOf("br");

        if (index > 0) {          

            var diachi = data_diachi_re.toString().substr(0, index - 1);

            $('#html_ketqua').append(ten_cty);
            $('#html_ketqua').append("<br />");
            $('#html_ketqua').append(diachi);
            $('#html_ketqua').append("<br />");
            $('#html_ketqua').append(masothue);
            $('#html_ketqua').append("<hr>");
            data_return.push({ 'ten': ten_cty, 'diachi': diachi, 'mst': masothue });

        }
    }); 
     

}
    


window.showdata = function()
{    

    $('#gridContainer').dxDataGrid({
        dataSource: data_return,
        keyExpr: 'mst',
        showBorders: true,
        selection: {
            mode: 'multiple',
        },
        groupPanel: {
            visible: true,
        },
        export: {
            enabled: true,
            allowExportSelectedData: true,
        },
        onExporting(e) {
            const workbook = new ExcelJS.Workbook();
            const worksheet = workbook.addWorksheet('Employees');

            DevExpress.excelExporter.exportDataGrid({
                component: e.component,
                worksheet,
                autoFilterEnabled: true,
            }).then(() => {
                workbook.xlsx.writeBuffer().then((buffer) => {
                    saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'Employees.xlsx');
                });
            });
            e.cancel = true;
        },
        columns: [
            'ten',
            'diachi',
            'mst',

        ],
    });
}







