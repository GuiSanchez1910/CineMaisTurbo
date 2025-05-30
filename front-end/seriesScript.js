$(document).ready(function () {

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Acao",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide serie-img">
                    <img class="serie-img" data-id="${serie.id}" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-acao').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=FiccaoCientifica",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-ficcaoCientifica').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Aventura",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-aventura').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Animacao",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-animacao').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Comedia",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-comedia').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Documentario",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-documentario').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Acao",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-acao').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Drama",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-drama').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Fantasia",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-fantasia').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Faroeste",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-faroeste').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Romance",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-romance').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Terror",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-terror').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });

    $.ajax({
        type: "GET",
        url: "http://localhost:5018/api/series?genero=Suspense",
        dataType: "json",
        success: function (response) {
            let html = ''

            response.forEach(serie => {
                html += `
                <div class="swiper-slide">
                    <img data-id="${serie.id}" class="serie-img" width=200 src="${serie.foto}" alt="${serie.nome}">
                </div>
                `;
            });

            $('#carrossel-suspense').append(html);
        },
        error: function () {
            console.error('erro meu');
        }
    });



    $(document).on('click', '.serie-img', function () {
        const serieId = $(this).data('id');

        $.ajax({
            type: "GET",
            url: `http://localhost:5018/api/series/${serieId}`,
            dataType: "json",
            success: function (serie) {
                Swal.fire({
                    html: `
                        <div class="text-white p-4" style="
                            background: linear-gradient(rgba(0,0,0,0.92), rgba(0,0,0,0.92)), url('${serie.foto}') no-repeat center center;
                            background-size: cover;
                            border-radius: 10px;">
                            <div class="row">
                                <div class="col-md-4 text-center mb-3">
                                    <img class="img-fluid rounded shadow" src="${serie.foto}" alt="${serie.nome}">
                                    <div class="mt-3">
                                        <label><strong>URL da Foto/Poster:</strong></label>
                                        <input type="text" class="form-control" id="input-foto" value="${serie.foto}">
                                    </div>
                                </div>
                                
                                <div class="col-md-8">
                                <div class="mb-2">
                                <label><strong>Nome:</strong></label>
                                <input type="text" class="form-control" id="input-nome" value="${serie.nome}">
                            </div>

                                <div class="mb-2">
                                    <div class="form-group">
                                        <label for="genero">Gênero:</label>
                                        <select value=${serie.genero} name="genero" id="input-genero">
                                            <option value="" disabled >Selecione uma opção</option>
                                            <option value="Acao">Ação</option>
                                            <option value="Aventura">Aventura</option>
                                            <option value="Animacao">Animação</option>
                                            <option value="Comedia">Comédia</option>
                                            <option value="Documentario">Documentário</option>
                                            <option value="Drama">Drama</option>
                                            <option value="Fantasia">Fantasia</option>
                                            <option value="Faroeste">Faroeste</option>
                                            <option value="FiccaoCientifica">Ficção Científica</option>
                                            <option value="Romance">Romance</option>
                                            <option value="Suspense">Suspense</option>
                                            <option value="Terror">Terror</option>
                                        </select>
                                    </div>
                                </div>

                                <div class="mb-2">
                                    <label><strong>Nota IMDB:</strong></label>
                                    <input type="number" class="form-control" id="input-imdb" value="${serie.avaliacaoImdb}">
                                </div>

                                <div class="mb-2">
                                    <label><strong>Nota Tomates:</strong></label>
                                    <input type="number" class="form-control" id="input-tomates" value="${serie.avaliacaoTomates}">
                                </div>

                                <div class="mb-2">
                                    <label><strong>Avaliação:</strong></label>
                                    <input type="number" class="form-control" id="input-avaliacao" value="${serie.avaliacao}">
                                </div>
                                <div class="mb-2">
                                <label><strong>Lançamento:</strong></label>
                                <input type="date" class="form-control" id="input-lancamento" value="${new Date(serie.lancamento).toISOString().split('T')[0]}">
                            </div>
                                </div>
                            </div>

                            <div class="row mt-3">
                                <div class="col">
                                <label><h4>Sinopse</h4></label>
                                <textarea class="form-control" id="input-sinopse" rows="4">${serie.sinopse}</textarea>
                                </div>
                            </div>

                            <div class="row mt-4 justify-content-center text-center">
                                <div class="col-auto">
                                </div>
                                <div class="col-auto">
                                <button type="button" class="btn btn-danger excluirserie" data-id="${serie.id}">
                                    <i class="fa-solid fa-trash"></i>&nbsp;EXCLUIR
                                </button>
                                </div>
                                <div class="col-auto">
                                <button type="button" class="btn btn-warning editarserie" data-id="${serie.id}">
                                    <i class="fa-solid fa-pen-to-square"></i>&nbsp;EDITAR
                                </button>
                                </div>
                                <div class="col-auto">
                                </div>
                            </div>
                        </div>
                    `,
                    didOpen: () => {
                        $('#input-genero').val(serie.genero); // define o gênero corretamente
                        document.querySelector('.swal2-popup').style.backgroundImage = `linear-gradient(rgba(0,0,0,0.92), rgba(0,0,0,0.92)), url('${serie.foto}')`;
                    },
                    showCloseButton: true,
                    showConfirmButton: false,
                    width: '1000px',
                    background: 'transparent',
                    customClass: {
                        popup: 'popup-altura'
                    }
                });
            },
            error: function () {
                Swal.fire('Erro', 'Não foi possível carregar os detalhes do serie.', 'error');
            }
        });
    });

});

$(document).on('click', '.excluirserie', function () {

    let id = $(this).data('id');

    Swal.fire({
        title: "Tem certeza?",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Sim, deletar!",
        cancelButtonText: "Cancelar"

    }).then((result) => {
        if (result.isConfirmed) {

            $.ajax({
                type: "DELETE",
                url: `http://localhost:5018/api/series/${id}`,
                success: function () {

                    $(`img[data-id="${id}"]`).closest('.swiper-slide').remove();

                    Swal.fire({
                        title: "Sucesso!",
                        text: "serie deletado com sucesso.",
                        icon: "success"
                    });
                },
                error: function () {
                    Swal.fire({
                        title: "Erro!",
                        text: "Erro ao deletar serie.",
                        icon: "error"
                    });
                }
            });
        }
    });
});

$(document).on('click', '.editarserie', function () {
    const id = $(this).data('id');

    const dadosAtualizados = {
        nome: $('#input-nome').val(),
        foto: $('#input-foto').val(),
        lancamento: $('#input-lancamento').val(),
        genero: $('#input-genero').val(),
        duracao: $('#input-duracao').val(),
        avaliacaoImdb: parseInt($('#input-imdb').val()),
        avaliacaoTomates: parseInt($('#input-tomates').val()),
        avaliacao: parseInt($('#input-avaliacao').val()),
        sinopse: $('#input-sinopse').val(),

    };

    $.ajax({
        type: "PUT",
        url: `http://localhost:5018/api/series/${id}`,
        contentType: "application/json",
        data: JSON.stringify(dadosAtualizados),
        success: function () {
            Swal.fire({
                icon: 'success',
                title: 'serie atualizado!',
                text: 'As informações foram salvas com sucesso.'
            }).then(() => location.reload());
        },
        error: function () {
            Swal.fire({
                icon: 'error',
                title: 'Erro ao atualizar',
                text: 'Não foi possível salvar as alterações.'
            });
        }
    });

});

$(document).ready(function () {

    setTimeout(() => {
        const swiper = new Swiper('.swiper', {
            slidesPerView: 4,
            spaceBetween: 30,
            navigation: {
                nextEl: '.swiper-button-next.serie',
                prevEl: '.swiper-button-prev.serie',
            },
            loop: true,
        });
    }, 100);

    setTimeout(() => {
        const swiper = new Swiper('.destaque', {
            slidesPerView: 1,
            spaceBetween: 30,
            loop: true,
            speed: 1000,
            effect: 'fade',
            fadeEffect: {
                crossFade: true
            },
            navigation: {
                nextEl: '.swiper-button-next.destaque',
                prevEl: '.swiper-button-prev.destaque',
            },
            on: {
                slideChangeTransitionStart: function () {
                    this.slides.forEach(slide => {
                        const iframe = slide.querySelector('iframe');
                        if (iframe && iframe.src.includes('youtube.com')) {
                            iframe.contentWindow.postMessage('{"event":"command","func":"pauseVideo","args":""}', '*');
                        }
                    });
                }
            }

        });
    }, 100);
});

const canvas = document.getElementById('starCanvas');
const ctx = canvas.getContext('2d');
let stars = [];

function resizeCanvas() {
    canvas.width = document.querySelector('.nav-menu').offsetWidth;
    canvas.height = document.querySelector('.nav-menu').offsetHeight;
}

window.addEventListener('resize', () => {
    resizeCanvas();
    generateStars();
});

function generateStars() {
    stars = [];
    for (let i = 0; i < 100; i++) {
        stars.push({
            x: Math.random() * canvas.width,
            y: Math.random() * canvas.height,
            radius: Math.random() * 1.5,
            alpha: Math.random(),
            delta: Math.random() * 0.02
        });
    }
}

function animateStars() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    for (let star of stars) {
        ctx.beginPath();
        ctx.arc(star.x, star.y, star.radius, 0, Math.PI * 2);
        ctx.fillStyle = `rgba(255, 255, 255, ${star.alpha})`;
        ctx.fill();
        star.alpha += star.delta;
        if (star.alpha <= 0 || star.alpha >= 1) star.delta *= -1;
    }
    requestAnimationFrame(animateStars);
}

resizeCanvas();
generateStars();
animateStars();

const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add('visible');
            observer.unobserve(entry.target);
        }
    });
}, {
    threshold: 0.1
});

document.querySelectorAll('.fade-in').forEach(element => {
    observer.observe(element);
});