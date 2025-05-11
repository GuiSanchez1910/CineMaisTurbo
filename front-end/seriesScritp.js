// $.ajax({
//     url: 'http://localhost:5018/api/series',
//     method: 'GET',
//     dataType: 'json',
//     success: function (data) {

//         let html = "";

//         data.forEach(serie => {
//             html +=`
//                 <div class="card-serie">
//                     <img src="${serie.foto}" alt="${serie.nome}" style="width: 300px; height: auto;">
//                 </div>`
//             }); 

//             $('#series-container').append(html);
//     },
//     error: function (xhr, status, error) {
//         console.error('Erro ao buscar séries:', error);
//     }
// });

$.ajax({
    url: 'http://localhost:5018/api/series?genero=drama',
    method: 'GET',
    dataType: 'json',
    success: function (data) {
        let html = '';
        data.forEach(serie => {
            html += `
                <div class="card-serie">
                    <img src="${serie.foto}" alt="${serie.nome}" style="width: 300px;">
                    <h4>${serie.nome}</h4>
                </div>`;
        });
        $('#series-container').append(html);
    },
    error: function () {
        console.error('Erro ao buscar séries');
    }
});


$.ajax({
    type: "GET",
    url: "http://localhost:5018/api/filmes?genero=drama",
    data: "data",
    dataType: "dataType",
    success: function (response) {
        
    }
});