// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let table = $('#table_cust').DataTable({
    dom: '<"top"Blf>rtip',
    buttons: [
        {
            extend: 'excelHtml5',
            className: 'btn btn-success mb-3 fa-solid fa-file-excel fa-2x px-4',
            text: '',
            exportOptions: {
                columns: ':visible'
            },
            attr: {
                title: 'Export to Excel',
                'data-toggle': 'tooltip',
                'data-placement': 'top'
            }
        },
        {
            extend: 'pdfHtml5',
            className: 'btn btn-danger mb-3 fa-solid fa-file-pdf fa-2x px-4',
            text: '',
            exportOptions: {
                columns: ':visible'
            },
            attr: {
                title: 'Export to PDF',
                'data-toggle': 'tooltip',
                'data-placement': 'top'
            }
        },
        {
            extend: 'colvis',
            className: 'btn btn-dark',
            attr: {
                title: 'Ignore Column',
                'data-bs-toggle': 'tooltip',
                'data-bs-placement': 'top'
            }
        }

    ],
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
            data: "kodeNamaPanggilan"
        },
        {
            data: "alamatKTP"
        },
        {
            data: "rt"
        },
        {
            data: "rw"
        },
        {
            data: "kelurahan"
        },
        {
            data: "kecamatan"
        },
        {
            data: "kodePos"
        },
        {
            data: "kodeLokasi"
        },
        {
            data: "kodeGroup"
        },
        {
            data: "alamat"
        },
        {
            data: "kodeposrumah"
        },
        {
            data: "noHP"
        },
        {
            data: "npwp"
        },
        {
            data: "namaIbuKandung"
        },
        {
            data: "kodeAgama",
            render: function (data, type, row) {
                if (row.kodeAgama == 0) {
                    return "Islam";
                }
                else if (row.kodeAgama == 1) {
                    return "Katholik";
                } else if (row.kodeAgama == 2) {
                    return "Kristen Protestan";
                } else if (row.kodeAgama == 3) {
                    return "Budha";
                } else if (row.kodeAgama == 4) {
                    return "Hindhu";
                }
            }
        },
        {
            data: "tanggalLahir"
        },
        {
            data: "tempatLahir"
        },
        {
            data: "statusPerkawinan"
        },
        {
            data: ["namaDepanPasangan", "namaBelakangPasangan"],
            render: (data, type, row, meta) => {
                return row.namaDepanPasangan + " " + row.namaBelakangPasangan;
            }
        },
        {
            data: "noIdentitasPasangan"
        },
        {
            data: "tanggalLahirPasangan",
            render: function (data, type, row) {
                return `<p class="text-xs mb-0">${moment(data).format('YYYY/MM/DD')}</p>`
            }
        },
        {
            data: "jenisKelamin",
            render: function (data, type, row) {
                if (row.gender == 0) {
                    return "Laki-Laki";
                }
                else {
                    return "Perempuan";
                }
            }
        },
        {
            data: "pekerjaan"
        },
        {
            data: "namaPerusahaan"
        },
        {
            data: "alamatPerusahaan"
        },
        {
            data: "npwpPerusahaan"
        },
        {
            data: "tanggalPendirianPerusahaan",
            render: function (data, type, row) {
                return `<p class="text-xs mb-0">${moment(data).format('YYYY/MM/DD')}</p>`
            }
        },
        {
            data: "tanggalLahirPemegangSaham",
            render: function (data, type, row) {
                return `<p class="text-xs mb-0">${moment(data).format('YYYY/MM/DD')}</p>`
            }
        },
        {
            data: "teleponKantor"
        },
        {
            data: "pendapatanPerbulan",
            render: function (data, type, row) {
                return `Rp. ` + data;
            }
        },
        {
            data: "tujuanPenggunaan"
        },
        {
            data: "jumlahKredit",
            render: function (data, type, row) {
                return `Rp. ` + data;
            }
        },
        {
            data: "tenor"
        },
        {
            data: "nppSales"
        },
        {
            data: "noidentitasKTP",
            render: function (data) {
                return `<a href="Pelanggan/Edit?data=${data}" ><button type="button" class="btn btn-warning" onclick="Edit(\'${data}'\)" >Edit</button></a>
                    <button class="btn btn-danger" onclick="Delete(\'${data}'\)" data-bs-toggle="tooltip" data-original-title="Edit user">Delete</button>`;
            }
        }
    ]
});

//JS UNTUK KODE POS
//let table1 = $('#tData').DataTable({
//    dom: '<"top"Blf>rtip',

//    ajax: {
//        url: "https://kodepos.vercel.app/search/?q=50187",
//        dataType: "Json",
//        dataSrc: "data" //need notice, kalau misal API kalian
//    },
//    columns: [
//        {
//            "data": "province"
//        },
//        {
//            "data": "city"
//        },
//        {
//            "data": "subdistrict"
//        },
//        {
//            "data": "urban"
//        },
//        {
//            "data": "postalcode"
//        }
//    ]
//});

const Edit = (key) => {
    //check = true
    $.ajax({
        url: `https://localhost:7131/api/Pelanggans/${key}`
    }).done((result) => {
        console.log(ViewBag.Id);

        $("#kodeNamaPanggilan").val(result.data.kodeNamaPanggilan),
        $("#namaDepan").val(result.data.namaDepan),
        $("#namaBelakang").val(result.data.namaBelakang),
            $("#alamatKTP").val(result.data.alamatKTP),
        $("#rt").val(result.data.rt),
        $("#rw").val(result.data.rw),
        $("#kelurahan").val(result.data.kelurahan),
        $("#kecamatan").val(result.data.kecamatan),
        $("#kodePos").val(result.data.kodePos),
        $("#kodeLokasi").val(result.data.kodeLokasi),
        $("#kodeGroup").val(result.data.kodeGroup),
        $("#noidentitasKTP").val(result.data.noidentitasKTP),
            $("#noidentitasKTP").attr("disabled", true);
        $("#alamat").val(result.data.alamat),
        $("#kodeposrumah").val(result.data.kodeposrumah),
        $("#noHP").val(result.data.noHP),
        $("#npwp").val(result.data.npwp),
        $("#namaIbuKandung").val(result.data.namaIbuKandung),
        $("#kodeAgama").val(result.data.kodeAgama),
        $("#tanggalLahir").val(result.data.tanggalLahir),
        $("#tempatLahir").val(result.data.tempatLahir),
            $("#statusPerkawinan").val(result.data.statusPerkawinan),
            $("#namaDepanPasangan").val(result.data.namaDepanPasangan),
            $("#namaBelakangPasangan").val(result.data.namaBelakangPasangan),
            $("#noIdentitasPasangan").val(result.data.noIdentitasPasangan),
            $("#tanggalLahirPasangan").val(result.data.tanggalLahirPasangan),
            $("#jenisKelamin").val(result.data.jenisKelamin),
            $("#pekerjaan").val(result.data.pekerjaan),
            $("#namaPerusahaan").val(result.data.namaPerusahaan),
            $("#alamatPerusahaan").val(result.data.alamatPerusahaan),
            $("#npwpPerusahaan").val(result.data.npwpPerusahaan),
            $("#tanggalPendirianPerusahaan").val(result.data.tanggalPendirianPerusahaan),
            $("#tanggalLahirPemegangSaham").val(result.data.tanggalLahirPemegangSaham),
            $("#teleponKantor").val(result.data.teleponKantor),
            $("#pendapatanPerbulan").val(result.data.pendapatanPerbulan),
            $("#tujuanPenggunaan").val(result.data.tujuanPenggunaan),
            $("#jumlahKredit").val(result.data.jumlahKredit),
            $("#tenor").val(result.data.tenor),
            $("#nppSales").val(result.data.nppSales)
    })
}

//const Insert = () => {
//    let employee = {
//        //NIK ETC are sensitive case, so watch your column name on your database
//        kodeNamaPanggilan: $("#kodeNamaPanggilan").val(),
//        namaDepan: $("#namaDepan").val(),
//        namaBelakang: $("#namaBelakang").val(),
//        alamatKTP: $("#alamatKTP").val(),
//            rt: $("#rt").val(),
//            rw: $("#rw").val(),
//            kelurahan: $("#kelurahan").val(),
//            kecamatan: $("#kecamatan").val(),
//            kodePos: $("#kodePos").val(),
//            kodeLokasi: $("#kodeLokasi").val(),
//            kodeGroup: $("#kodeGroup").val(),
//            noidentitasKTP: $("#noidentitasKTP").val(),
//            alamat: $("#alamat").val(),
//            kodeposrumah: $("#kodeposrumah").val(),
//            noHP: $("#noHP").val(),
//            npwp: $("#npwp").val(),
//            namaIbuKandung: $("#namaIbuKandung").val(),
//            kodeAgama: parseInt($("#kodeAgama").val()),
//            tanggalLahir: $("#tanggalLahir").val(),
//            tempatLahir: $("#tempatLahir").val(),
//            statusPerkawinan: $("#statusPerkawinan").val(),
//            namaDepanPasangan: $("#namaDepanPasangan").val(),
//            namaBelakangPasangan: $("#namaBelakangPasangan").val(),
//            noIdentitasPasangan: $("#noIdentitasPasangan").val(),
//            tanggalLahirPasangan: $("#tanggalLahirPasangan").val(),
//            jenisKelamin: parseInt($("#jenisKelamin").val()),
//            pekerjaan: $("#pekerjaan").val(),
//            namaPerusahaan: $("#namaPerusahaan").val(),
//            alamatPerusahaan: $("#alamatPerusahaan").val(),
//            npwpPerusahaan: $("#npwpPerusahaan").val(),
//            tanggalPendirianPerusahaan: $("#tanggalPendirianPerusahaan").val(),
//            tanggalLahirPemegangSaham: $("#tanggalLahirPemegangSaham").val(),
//            teleponKantor: $("#teleponKantor").val(),
//            pendapatanPerbulan: $("#pendapatanPerbulan").val(),
//            tujuanPenggunaan: $("#tujuanPenggunaan").val(),
//            jumlahKredit: $("#jumlahKredit").val(),
//            tenor: $("#tenor").val(),
//            nppSales: $("#nppSales").val()
//    }

//    console.log(employee);

//    $.ajax({
//        url: "https://localhost:7131/api/Pelanggans",
//        type: "POST",
//        contentType: "application/json",
//        data: JSON.stringify(employee),
//    }).done((result) => {
//        console.log("success");
//        $("#modalInsert").modal("hide");
//        Swal.fire({
//            text: 'New Employee Created!',
//            icon: 'success',
//            timer: 5000,
//            timerProgressBar: true
//        });
//        table.ajax.reload()
//    }).fail((error) => {
//        console.log("failed");
//        $("#modalInsert").modal("hide");
//        Swal.fire({
//            text: 'Error Creating Project!',
//            icon: 'error',
//            timer: 5000,
//            timerProgressBar: true
//        });
//    })
//};