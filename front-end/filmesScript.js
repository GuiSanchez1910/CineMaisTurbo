
$(document).ready(function () {
    
    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/filmes?genero=Fantasia",
        dataType: "json",
        success: function (response) {
            let html = ''
    
            response.forEach(filme => {
                html +=`
                <div class="swiper-slide">
                    <img width=200 src="${filme.foto}" alt="Filme 1">
                </div>
                `;
            });
    
            $('#carrossel-fantasia').append(html);
        },
        error: function() {
            console.error('erro meu');
        }
    });
    
    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/filmes?genero=FiccaoCientifica",
        dataType: "json",
        success: function (response) {
            let html = ''
    
            response.forEach(filme => {
                html +=`
                <div class="swiper-slide">
                    <img width=200 src="${filme.foto}" alt="Filme 1">
                </div>
                `;
            });
    
            $('#carrossel-ficcaoCientifica').append(html);
        },
        error: function() {
            console.error('erro meu');
        }
    });

    // $.ajax({
    // type: "GET",
    // url: "http://localhost:5018/api/filmes?genero=Fantasia",
    // dataType: "json",
    // success: function (response) {
    //     let inner = '';
    //     let grupo = [];

    //     response.forEach((filme, index) => {
    //         grupo.push(`
    //             <div class="col-3 d-flex justify-content-center">
    //                 <div class="card">
    //                     <img src="${filme.foto}" class="img-fluid" alt="${filme.nome}">
    //                 </div>
    //             </div>
    //         `);

    //         // Quando completar 4 ou for o último
    //         if ((index + 1) % 4 === 0 || index === response.length - 1) {
    //             while (grupo.length < 4) {
    //                 grupo.push(`
    //                     <div class="col-3 d-flex justify-content-center">
    //                         <div class="card" style="visibility: hidden;">
    //                             <img src="#" class="img-fluid" alt="">
    //                         </div>
    //                     </div>
    //                 `);
    //             }

    //             inner += `
    //                 <div class="carousel-item ${inner === '' ? 'active' : ''}">
    //                     <div class="row px-3">${grupo.join('')}</div>
    //                 </div>
    //             `;
    //             grupo = [];
    //         }
    //     });

    //     $('#carousel-inner-fantasia').html(inner);
    // },
    // error: function () {
    //     console.error('Erro ao carregar os filmes');
    // }
});

