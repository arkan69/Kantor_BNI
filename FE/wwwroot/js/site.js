// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let tabel = $('#custom').DataTable({
    
    ajax: {
        url: "https://localhost:7131/api/Pelanggans",
        dataType: "Json",
        dataSrc: "" //need notice, kalau misal API kalian 
    },
    columns: [
        {
            data: "id",
            render: function (data, type, row, meta) {
                return meta.row + meta.settings._iDisplayStart + 1;
            }
        },
        {
            data: "noidentitasKTP"
        },
        {
            data: ["namaDepan", "namaBelakang"],
            render: (data, type, row, meta) => {
                return row.namaDepan + " " + row.namaBelakang;
            }
        },
        {
            data: "noHP"
        },
        {
            data: "npwp"
        }
    ]
});