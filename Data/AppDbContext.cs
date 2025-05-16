using CineMaisTurbo.Models;
using CineTurbo.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTurbo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Filme> FilmesDB { get; set; }
        public DbSet<Serie> SeriesDB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Filme>().HasData(
                new Filme
                {
                    Id = 1,
                    Nome = "Mad Max: Estrada da Fúria",
                    Sinopse = "Em um mundo pós-apocalíptico, Max se une a uma misteriosa mulher para fugir de um tirano.",
                    AvaliacaoImdb = 85,
                    AvaliacaoTomates = 97,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg",
                    Genero = "Acao",
                    Avaliacao = 5,
                    Duracao = "2h",
                    Lancamento = new DateTime(2015, 5, 15)
                },
                new Filme
                {
                    Id = 2,
                    Nome = "John Wick",
                    Sinopse = "Um ex-assassino busca vingança contra aqueles que destruíram sua vida.",
                    AvaliacaoImdb = 74,
                    AvaliacaoTomates = 86,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/fZPSd91yGE9fCcCe6OoQr6E3Bev.jpg",
                    Genero = "Acao",
                    Avaliacao = 4,
                    Duracao = "1h 41min",
                    Lancamento = new DateTime(2014, 10, 24)
                },
                new Filme
                {
                    Id = 3,
                    Nome = "Duro de Matar",
                    Sinopse = "Um policial de Nova York enfrenta terroristas que tomam um arranha-céu em Los Angeles.",
                    AvaliacaoImdb = 82,
                    AvaliacaoTomates = 94,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/1nAfchiXHQB3iyhK8fCJJEnNs5A.jpg",
                    Genero = "Acao",
                    Avaliacao = 5,
                    Duracao = "2h 12min",
                    Lancamento = new DateTime(1988, 7, 15)
                },
                new Filme
                {
                    Id = 4,
                    Nome = "O Cavaleiro das Trevas",
                    Sinopse = "Batman enfrenta o Coringa, um criminoso que semeia o caos em Gotham.",
                    AvaliacaoImdb = 90,
                    AvaliacaoTomates = 94,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
                    Genero = "Acao",
                    Avaliacao = 5,
                    Duracao = "2h 32min",
                    Lancamento = new DateTime(2008, 7, 18)
                },
                new Filme
                {
                    Id = 5,
                    Nome = "Gladiador",
                    Sinopse = "Um general romano busca vingança após ser traído e ver sua família assassinada.",
                    AvaliacaoImdb = 85,
                    AvaliacaoTomates = 77,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg",
                    Genero = "Acao",
                    Avaliacao = 5,
                    Duracao = "2h 35min",
                    Lancamento = new DateTime(2000, 5, 5)
                },
                new Filme
                {
                    Id = 6,
                    Nome = "Indiana Jones e os Caçadores da Arca Perdida",
                    Sinopse = "Em 1936, o arqueólogo e aventureiro Indiana Jones é contratado pelo governo dos EUA para encontrar a Arca da Aliança antes que os nazistas a obtenham. Em uma corrida contra o tempo, Jones enfrenta perigos mortais em locais exóticos, desvendando enigmas antigos e enfrentando inimigos implacáveis em sua busca por um artefato sagrado que pode mudar o curso da história.",
                    AvaliacaoImdb = 85,
                    AvaliacaoTomates = 95,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/ceG9VzoRAVGwivFU403Wc3AHRys.jpg",
                    Genero = "Aventura",
                    Avaliacao = 5,
                    Duracao = "1h 55min",
                    Lancamento = new DateTime(1981, 6, 12)
                },
                new Filme
                {
                    Id = 7,
                    Nome = "Piratas do Caribe: A Maldição do Pérola Negra",
                    Sinopse = "O capitão Jack Sparrow embarca em uma jornada para recuperar seu navio, o Pérola Negra, das mãos do traiçoeiro capitão Barbossa, que lidera uma tripulação amaldiçoada. Com a ajuda de Will Turner e Elizabeth Swann, Jack enfrenta perigos sobrenaturais, batalhas épicas e traições em alto-mar, em uma aventura repleta de ação e humor.",
                    AvaliacaoImdb = 80,
                    AvaliacaoTomates = 79,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/l3peI54mf6Z9EBSvS3hnRmOBbFT.jpg",
                    Genero = "Aventura",
                    Avaliacao = 5,
                    Duracao = "2h 23min",
                    Lancamento = new DateTime(2003, 7, 9)
                },
                new Filme
                {
                    Id = 8,
                    Nome = "As Aventuras de Tintim",
                    Sinopse = "O jovem repórter Tintim e seu fiel cão Milu descobrem um modelo de navio que contém pistas sobre um tesouro perdido. Juntos, eles embarcam em uma jornada ao redor do mundo, enfrentando vilões perigosos e desvendando mistérios ancestrais, em uma aventura cheia de ação, suspense e descobertas.",
                    AvaliacaoImdb = 73,
                    AvaliacaoTomates = 74,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/lSzqfKyzb7nRCZ3qihPhdspZeMA.jpg",
                    Genero = "Aventura",
                    Avaliacao = 4,
                    Duracao = "1h 47min",
                    Lancamento = new DateTime(2011, 10, 26)
                },
                new Filme
                {
                    Id = 9,
                    Nome = "Jumanji",
                    Sinopse = "Ao descobrir um misterioso jogo de tabuleiro, dois irmãos libertam Alan Parrish, que estava preso no jogo há 26 anos. Agora, eles devem enfrentar criaturas selvagens e desafios perigosos que escapam do jogo para o mundo real, tentando terminar a partida para restaurar a normalidade.",
                    AvaliacaoImdb = 71,
                    AvaliacaoTomates = 55,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/vgpXmVaVyUL7GGiDeiK1mKEKzcX.jpg",
                    Genero = "Aventura",
                    Avaliacao = 4,
                    Duracao = "1h 44min",
                    Lancamento = new DateTime(1995, 12, 15)
                },
                new Filme
                {
                    Id = 10,
                    Nome = "A Viagem de Chihiro",
                    Sinopse = "Chihiro, uma garota de 10 anos, se vê presa em um mundo mágico após seus pais serem transformados em porcos. Para salvá-los e retornar ao mundo real, ela deve trabalhar em uma casa de banhos para espíritos, enfrentando desafios e descobrindo sua coragem interior em uma jornada de autodescoberta.",
                    AvaliacaoImdb = 86,
                    AvaliacaoTomates = 97,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg",
                    Genero = "Aventura",
                    Avaliacao = 5,
                    Duracao = "2h 5min",
                    Lancamento = new DateTime(2001, 7, 20)
                },
                new Filme
                {
                    Id = 11,
                    Nome = "Divertida Mente",
                    Sinopse = "Riley é uma garota de 11 anos que enfrenta mudanças importantes em sua vida quando seus pais decidem se mudar para San Francisco. Dentro de sua mente, cinco emoções — Alegria, Tristeza, Medo, Raiva e Nojinho — trabalham juntas para guiá-la em sua nova realidade, enfrentando desafios e aprendendo a lidar com sentimentos complexos.",
                    AvaliacaoImdb = 81,
                    AvaliacaoTomates = 98,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lRHE0vzf3oYJrhbsHXjIkF4Tl5A.jpg",
                    Genero = "Animacao",
                    Avaliacao = 5,
                    Duracao = "1h 35min",
                    Lancamento = new DateTime(2015, 6, 19)
                },
                new Filme
                {
                    Id = 12,
                    Nome = "Viva: A Vida é uma Festa",
                    Sinopse = "Miguel é um garoto mexicano de 12 anos que sonha em se tornar um grande músico, apesar da proibição de sua família. Determinado a provar seu talento, ele acaba transportado para a Terra dos Mortos, onde encontra seus ancestrais e descobre segredos sobre sua história familiar, embarcando em uma jornada emocionante sobre memória e identidade.",
                    AvaliacaoImdb = 84,
                    AvaliacaoTomates = 97,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/gGEsBPAijhVUFoiNpgZXqRVWJt2.jpg",
                    Genero = "Animacao",
                    Avaliacao = 5,
                    Duracao = "1h 45min",
                    Lancamento = new DateTime(2017, 11, 22)
                },
                new Filme
                {
                    Id = 13,
                    Nome = "Zootopia",
                    Sinopse = "Em uma cidade habitada por animais antropomórficos, a coelha Judy Hopps realiza seu sonho de se tornar a primeira oficial de polícia de sua espécie. Para provar seu valor, ela se une ao raposo trapaceiro Nick Wilde para desvendar um mistério que ameaça a paz entre predadores e presas.",
                    AvaliacaoImdb = 80,
                    AvaliacaoTomates = 98,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/jyjBSQ7lCS2XolhbLeAH5HhXahY.jpg",
                    Genero = "Animacao",
                    Avaliacao = 5,
                    Duracao = "1h 48min",
                    Lancamento = new DateTime(2016, 3, 17)
                },
                new Filme
                {
                    Id = 14,
                    Nome = "Up: Altas Aventuras",
                    Sinopse = "Carl Fredricksen, um vendedor de balões de 78 anos, realiza o sonho de sua falecida esposa ao prender milhares de balões em sua casa e voar para a América do Sul. Sem querer, ele leva consigo Russell, um escoteiro de 8 anos, e juntos vivem uma aventura inesquecível cheia de descobertas e amizades.",
                    AvaliacaoImdb = 82,
                    AvaliacaoTomates = 98,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/6FnpYYl90HeR2tnAgOTaa7jk8oD.jpg",
                    Genero = "Animacao",
                    Avaliacao = 5,
                    Duracao = "1h 36min",
                    Lancamento = new DateTime(2009, 5, 29)
                },
                new Filme
                {
                    Id = 15,
                    Nome = "Wall-E",
                    Sinopse = "Em um futuro distante, a Terra está coberta de lixo e abandonada pelos humanos. Wall-E, um pequeno robô compactador de lixo, continua sua rotina solitária até encontrar Eva, uma robô enviada para procurar sinais de vida. Juntos, eles embarcam em uma jornada que pode determinar o futuro da humanidade.",
                    AvaliacaoImdb = 84,
                    AvaliacaoTomates = 95,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/2TfYp0eMPrcKNjX6PTKGGQODjfF.jpg",
                    Genero = "Animacao",
                    Avaliacao = 5,
                    Duracao = "1h 38min",
                    Lancamento = new DateTime(2008, 6, 27)
                },
                new Filme
                {
                    Id = 16,
                    Nome = "Se Beber, Não Case!",
                    Sinopse = "Quatro amigos viajam para Las Vegas para uma despedida de solteiro inesquecível. Após uma noite de festas, eles acordam sem memória dos acontecimentos e descobrem que o noivo desapareceu. Em uma corrida contra o tempo, eles tentam reconstruir os eventos da noite anterior para encontrar seu amigo antes do casamento.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 79,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/uluhlXubGu1VxU63X9VHCLWDAYP.jpg",
                    Genero = "Comedia",
                    Avaliacao = 5,
                    Duracao = "1h 40min",
                    Lancamento = new DateTime(2009, 6, 5)
                },
                new Filme
                {
                    Id = 17,
                    Nome = "As Branquelas",
                    Sinopse = "Dois agentes do FBI, após uma missão fracassada, precisam proteger duas herdeiras de uma possível ameaça de sequestro. Para isso, eles se disfarçam como as irmãs ricas, mergulhando em um mundo de alta sociedade e enfrentando situações hilárias enquanto tentam manter suas identidades em segredo.",
                    AvaliacaoImdb = 56,
                    AvaliacaoTomates = 15,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/aJZOcorpgloDLkPP6ED0t9sXjNu.jpg",
                    Genero = "Comedia",
                    Avaliacao = 4,
                    Duracao = "1h 49min",
                    Lancamento = new DateTime(2004, 6, 23)
                },
                new Filme
                {
                    Id = 18,
                    Nome = "Curtindo a Vida Adoidado",
                    Sinopse = "Ferris Bueller, um estudante do ensino médio, decide tirar um dia de folga e viver aventuras com sua namorada e melhor amigo. Enquanto isso, o diretor da escola está determinado a desmascarar sua farsa, levando a uma série de situações cômicas e inesquecíveis.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 80,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/kUqhcfr5IoaE76NOIQl53gn3y3Q.jpg",
                    Genero = "Comedia",
                    Avaliacao = 5,
                    Duracao = "1h 43min",
                    Lancamento = new DateTime(1986, 6, 11)
                },
                new Filme
                {
                    Id = 19,
                    Nome = "O Virgem de 40 Anos",
                    Sinopse = "Andy Stitzer é um homem de 40 anos que nunca teve relações sexuais. Quando seus colegas de trabalho descobrem seu segredo, eles se propõem a ajudá-lo a perder a virgindade, levando a uma série de encontros desastrosos e situações embaraçosas.",
                    AvaliacaoImdb = 70,
                    AvaliacaoTomates = 85,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/e2qfitm4lm1g3mGc7nGmnnnQa3c.jpg",
                    Genero = "Comedia",
                    Avaliacao = 4,
                    Duracao = "1h 56min",
                    Lancamento = new DateTime(2005, 8, 19)
                },
                new Filme
                {
                    Id = 20,
                    Nome = "O Máskara",
                    Sinopse = "Stanley Ipkiss é um bancário tímido que encontra uma máscara mágica que o transforma em um personagem carismático e cheio de energia. Com seus novos poderes, ele enfrenta criminosos e conquista a atenção da mulher de seus sonhos, mas também atrai a atenção de inimigos perigosos.",
                    AvaliacaoImdb = 69,
                    AvaliacaoTomates = 77,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/q9O7aYk2unOdKXt6HCCalF9Jup8.jpg",
                    Genero = "Comedia",
                    Avaliacao = 5,
                    Duracao = "1h 41min",
                    Lancamento = new DateTime(1994, 7, 29)
                },
                new Filme
                {
                    Id = 21,
                    Nome = "Waste Land",
                    Sinopse = "O artista plástico Vik Muniz viaja ao maior aterro sanitário do mundo, o Jardim Gramacho, no Rio de Janeiro, para criar obras de arte com materiais recicláveis e retratar a vida dos catadores. O documentário mostra como a arte pode transformar vidas e trazer dignidade a pessoas marginalizadas.",
                    AvaliacaoImdb = 79,
                    AvaliacaoTomates = 100,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/wvaVhCRVPSYZp2A3utfyrPl0dNw.jpg",
                    Genero = "Documentario",
                    Avaliacao = 5,
                    Duracao = "1h 39min",
                    Lancamento = new DateTime(2010, 1, 24)
                },
                new Filme
                {
                    Id = 22,
                    Nome = "Food, Inc.",
                    Sinopse = "Este documentário investiga a indústria alimentícia dos Estados Unidos, revelando práticas questionáveis na produção de alimentos e os impactos na saúde pública e no meio ambiente. Com entrevistas e análises, o filme busca conscientizar os consumidores sobre a origem dos alimentos que consomem.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 96,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/zdwN4o7OGAZGJw9T64lRAGTEP8b.jpg",
                    Genero = "Documentario",
                    Avaliacao = 5,
                    Duracao = "1h 34min",
                    Lancamento = new DateTime(2008, 9, 7)
                },
                new Filme
                {
                    Id = 23,
                    Nome = "Janela da Alma",
                    Sinopse = "Dezenove pessoas com diferentes graus de deficiência visual compartilham suas experiências e percepções sobre o mundo. O documentário aborda como a visão (ou a falta dela) influencia a maneira como cada indivíduo interpreta a realidade.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 90,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/fLJ56kNgzJnvv82oLumG395NKk5.jpg",
                    Genero = "Documentario",
                    Avaliacao = 4,
                    Duracao = "1h 13min",
                    Lancamento = new DateTime(2001, 10, 12)
                },
                new Filme
                {
                    Id = 24,
                    Nome = "All the Beauty and the Bloodshed",
                    Sinopse = "A fotógrafa Nan Goldin lidera uma campanha contra a família Sackler, responsabilizando-os pela crise dos opioides nos EUA. O documentário entrelaça sua trajetória artística com sua luta ativista, revelando os impactos devastadores do vício em opioides.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 93,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/cvO51xxtIUHc5w5ZgFsigiFaUaO.jpg",
                    Genero = "Documentario",
                    Avaliacao = 5,
                    Duracao = "1h 57min",
                    Lancamento = new DateTime(2022, 11, 23)
                },
                new Filme
                {
                    Id = 25,
                    Nome = "Rotten",
                    Sinopse = "Esta série documental investiga a corrupção e os problemas éticos na cadeia de produção de alimentos ao redor do mundo. Cada episódio expõe práticas controversas em diferentes setores da indústria alimentícia, alertando sobre os riscos para os consumidores.",
                    AvaliacaoImdb = 75,
                    AvaliacaoTomates = 86,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/5xz2tR3j4poNVHZWVXHzflOrTnM.jpg",
                    Genero = "Documentario",
                    Avaliacao = 4,
                    Duracao = "1h",
                    Lancamento = new DateTime(2018, 1, 5)
                },
                new Filme
                {
                    Id = 26,
                    Nome = "Um Sonho de Liberdade",
                    Sinopse = "Andy Dufresne, um banqueiro condenado injustamente pelo assassinato de sua esposa e do amante dela, é enviado à Penitenciária Estadual de Shawshank. Lá, ele forma uma amizade com Red, um prisioneiro que cumpre pena há décadas. Ao longo dos anos, Andy mantém sua esperança viva e planeja uma fuga que mudará sua vida para sempre.",
                    AvaliacaoImdb = 93,
                    AvaliacaoTomates = 91,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg",
                    Genero = "Drama",
                    Avaliacao = 5,
                    Duracao = "2h 22min",
                    Lancamento = new DateTime(1994, 9, 23)
                },
                new Filme
                {
                    Id = 27,
                    Nome = "O Poder do Cão",
                    Sinopse = "Em 1925, os irmãos Phil e George Burbank administram um rancho em Montana. Quando George se casa com Rose, uma viúva local, Phil inicia uma campanha cruel contra ela e seu filho Peter. No entanto, à medida que os eventos se desenrolam, segredos são revelados e as relações entre eles se tornam cada vez mais complexas.",
                    AvaliacaoImdb = 68,
                    AvaliacaoTomates = 94,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/kEy48iCzGnp0ao1cZbNeWR6yIhC.jpg",
                    Genero = "Drama",
                    Avaliacao = 4,
                    Duracao = "2h 6min",
                    Lancamento = new DateTime(2021, 11, 17)
                },
                new Filme
                {
                    Id = 28,
                    Nome = "Drive My Car",
                    Sinopse = "Yusuke Kafuku, um renomado ator e diretor de teatro, ainda lidando com a perda de sua esposa, aceita dirigir uma peça em Hiroshima. Lá, ele conhece Misaki, uma jovem motorista designada para conduzi-lo. À medida que passam tempo juntos, compartilham segredos e traumas, formando uma conexão profunda que os ajuda a enfrentar suas dores.",
                    AvaliacaoImdb = 76,
                    AvaliacaoTomates = 98,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9z4jRr43JdtU66P0iy8h18OyLql.jpg",
                    Genero = "Drama",
                    Avaliacao = 5,
                    Duracao = "2h 59min",
                    Lancamento = new DateTime(2021, 8, 20)
                },
                new Filme
                {
                    Id = 29,
                    Nome = "Batman",
                    Sinopse = "Em Gotham City, um misterioso vigilante conhecido como Batman combate o crime e enfrenta seu maior inimigo, o Coringa, um criminoso insano que ameaça mergulhar a cidade no caos.",
                    AvaliacaoImdb = 75,
                    AvaliacaoTomates = 73,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/cij4dd21v2Rk2YtUQbV5kW69WB2.jpg",
                    Genero = "Acao",
                    Avaliacao = 5,
                    Duracao = "2h 6min",
                    Lancamento = new DateTime(1989, 6, 23)
                },
                new Filme
                {
                    Id = 30,
                    Nome = "Mangrove",
                    Sinopse = "Baseado em eventos reais, o filme retrata a luta de Frank Crichlow, dono do restaurante Mangrove em Notting Hill, Londres, que se torna alvo de perseguição policial. Em resposta, ele e outros ativistas organizam protestos que culminam em um julgamento histórico, expondo o racismo institucionalizado na polícia britânica.",
                    AvaliacaoImdb = 76,
                    AvaliacaoTomates = 98,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/uKzsziGc04NGRa7ceK06Ivvhzac.jpg",
                    Genero = "Drama",
                    Avaliacao = 5,
                    Duracao = "2h 4min",
                    Lancamento = new DateTime(2020, 11, 15)
                },
                new Filme
                {
                    Id = 31,
                    Nome = "O Senhor dos Anéis: O Retorno do Rei",
                    Sinopse = "A conclusão épica da trilogia acompanha Frodo e Sam em sua jornada final para destruir o Um Anel, enquanto Aragorn lidera as forças de Gondor contra Sauron. Uma batalha monumental pelo destino da Terra Média se aproxima.",
                    AvaliacaoImdb = 91,
                    AvaliacaoTomates = 93,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "3h 21min",
                    Lancamento = new DateTime(2003, 12, 17)
                },
                new Filme
                {
                    Id = 32,
                    Nome = "Harry Potter e o Prisioneiro de Azkaban",
                    Sinopse = "No terceiro ano em Hogwarts, Harry descobre que Sirius Black, um perigoso prisioneiro, escapou de Azkaban e pode estar atrás dele. Enquanto isso, segredos sobre o passado de seus pais vêm à tona.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 90,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/aWxwnYoe8p2d2fcxOqtvAtJ72Rw.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 22min",
                    Lancamento = new DateTime(2004, 6, 4)
                },
                new Filme
                {
                    Id = 33,
                    Nome = "O Labirinto do Fauno",
                    Sinopse = "Na Espanha pós-guerra, a jovem Ofélia descobre um mundo mágico onde encontra um fauno que lhe propõe três tarefas para provar que é a reencarnação de uma princesa perdida.",
                    AvaliacaoImdb = 82,
                    AvaliacaoTomates = 95,
                    Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTyxxX4QmH1ucMni22YcJU6pW-xqoqsrwT9OA&s",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "1h 58min",
                    Lancamento = new DateTime(2006, 10, 11)
                },
                new Filme
                {
                    Id = 34,
                    Nome = "As Crônicas de Nárnia: O Leão, a Feiticeira e o Guarda-Roupa",
                    Sinopse = "Quatro irmãos descobrem um guarda-roupa que os transporta para Nárnia, um mundo mágico onde se juntam ao leão Aslan para derrotar a Feiticeira Branca e restaurar a paz.",
                    AvaliacaoImdb = 69,
                    AvaliacaoTomates = 76,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/iREd0rNCjYdf5Ar0vfaW32yrkm.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 4,
                    Duracao = "2h 23min",
                    Lancamento = new DateTime(2005, 12, 9)
                },
                new Filme
                {
                    Id = 35,
                    Nome = "A Viagem de Chihiro",
                    Sinopse = "Chihiro, uma garota de 10 anos, entra em um mundo mágico dominado por deuses, bruxas e espíritos, onde humanos são transformados em animais. Para salvar seus pais, ela deve encontrar coragem e sabedoria.",
                    AvaliacaoImdb = 85,
                    AvaliacaoTomates = 97,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 5min",
                    Lancamento = new DateTime(2001, 7, 20)
                },
                new Filme
                {
                    Id = 36,
                    Nome = "Três Homens em Conflito",
                    Sinopse = "Durante a Guerra Civil Americana, três pistoleiros — o Bom, o Mau e o Feio — formam uma aliança instável em busca de um tesouro em ouro enterrado em um cemitério. Em meio a traições e confrontos, eles enfrentam perigos e desafios em uma jornada épica pelo Velho Oeste.",
                    AvaliacaoImdb = 89,
                    AvaliacaoTomates = 97,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/bX2xnavhMYjWDoZp1VM6VnU1xwe.jpg",
                    Genero = "Faroeste",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(1966, 12, 23)
                },
                new Filme
                {
                    Id = 37,
                    Nome = "Os Imperdoáveis",
                    Sinopse = "Um pistoleiro aposentado é convencido a realizar um último trabalho para vingar uma prostituta desfigurada. Ao lado de antigos parceiros, ele enfrenta dilemas morais e confronta seu passado violento em um Oeste em transformação.",
                    AvaliacaoImdb = 82,
                    AvaliacaoTomates = 96,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/54roTwbX9fltg85zjsmrooXAs12.jpg",
                    Genero = "Faroeste",
                    Avaliacao = 5,
                    Duracao = "2h 10min",
                    Lancamento = new DateTime(1992, 8, 7)
                },
                new Filme
                {
                    Id = 38,
                    Nome = "Bravura Indômita",
                    Sinopse = "Após o assassinato de seu pai, uma jovem determinada contrata um xerife alcoólatra para ajudá-la a capturar o criminoso. Juntos, eles enfrentam perigos e desafios em uma jornada pelo território indígena.",
                    AvaliacaoImdb = 76,
                    AvaliacaoTomates = 96,
                    Foto = "https://m.media-amazon.com/images/M/MV5BMTU5MjU3MTI4OF5BMl5BanBnXkFtZTcwMTQxOTAxNA@@._V1_FMjpg_UX1000_.jpg",
                    Genero = "Faroeste",
                    Avaliacao = 4,
                    Duracao = "1h 50min",
                    Lancamento = new DateTime(2010, 12, 22)
                },
                new Filme
                {
                    Id = 39,
                    Nome = "Django Livre",
                    Sinopse = "No sul dos Estados Unidos, dois anos antes da Guerra Civil, Django, um escravo liberto, une forças com um caçador de recompensas alemão para resgatar sua esposa das mãos de um brutal fazendeiro.",
                    AvaliacaoImdb = 84,
                    AvaliacaoTomates = 87,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg",
                    Genero = "Faroeste",
                    Avaliacao = 5,
                    Duracao = "2h 45min",
                    Lancamento = new DateTime(2012, 12, 25)
                },
                new Filme
                {
                    Id = 40,
                    Nome = "O Assassinato de Jesse James pelo Covarde Robert Ford",
                    Sinopse = "A história do lendário fora-da-lei Jesse James e sua relação complexa com Robert Ford, um jovem admirador que eventualmente se torna seu assassino, explorando temas de fama, traição e arrependimento.",
                    AvaliacaoImdb = 74,
                    AvaliacaoTomates = 77,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/2d1S6fJS80fvseg6mJE8eq5o7Kx.jpg",
                    Genero = "Faroeste",
                    Avaliacao = 4,
                    Duracao = "2h 40min",
                    Lancamento = new DateTime(2007, 9, 21)
                },
                new Filme
                {
                    Id = 41,
                    Nome = "Interestelar",
                    Sinopse = "Em um futuro próximo, a Terra está à beira do colapso ambiental. Um grupo de astronautas embarca em uma missão interestelar para encontrar um novo lar para a humanidade, enfrentando desafios cósmicos e dilemas emocionais ao longo do caminho.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 72,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/nCbkOyOMTEwlEV0LtCOvCnwEONA.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "2h 49min",
                    Lancamento = new DateTime(2014, 11, 7)
                },
                new Filme
                {
                    Id = 42,
                    Nome = "Blade Runner 2049",
                    Sinopse = "Trinta anos após os eventos do primeiro filme, um novo blade runner, o oficial K, desenterra um segredo há muito enterrado que tem o potencial de mergulhar o que resta da sociedade no caos.",
                    AvaliacaoImdb = 80,
                    AvaliacaoTomates = 88,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/aMpyrCizvSdc0UIMblJ1srVgAEF.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "2h 44min",
                    Lancamento = new DateTime(2017, 10, 6)
                },
                new Filme
                {
                    Id = 43,
                    Nome = "A Chegada",
                    Sinopse = "Quando misteriosas naves espaciais pousam ao redor do mundo, uma equipe de elite liderada pela linguista Louise Banks é reunida para investigar. Enquanto a humanidade está à beira de uma guerra global, Banks e sua equipe correm contra o tempo para encontrar respostas.",
                    AvaliacaoImdb = 79,
                    AvaliacaoTomates = 94,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/dc3mXcrPJLRsbcdnlKqYJx718RZ.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "1h 56min",
                    Lancamento = new DateTime(2016, 11, 11)
                },
                new Filme
                {
                    Id = 44,
                    Nome = "Ex Machina: Instinto Artificial",
                    Sinopse = "Um jovem programador é selecionado para participar de um experimento inovador em inteligência artificial, avaliando as capacidades e a consciência de um robô humanoide avançado.",
                    AvaliacaoImdb = 77,
                    AvaliacaoTomates = 92,
                    Foto = "https://www.themoviedb.org/t/p/w1280/hfpnFtgcYom9Gk9s1IyWiovpZYg.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "1h 48min",
                    Lancamento = new DateTime(2015, 4, 10)
                },
                new Filme
                {
                    Id = 45,
                    Nome = "No Limite do Amanhã",
                    Sinopse = "Em um futuro próximo, a Terra é invadida por uma raça alienígena. O major William Cage é forçado a lutar e, ao ser morto, descobre que está preso em um loop temporal, revivendo o mesmo dia de combate repetidamente.",
                    AvaliacaoImdb = 79,
                    AvaliacaoTomates = 91,
                    Foto = "https://www.themoviedb.org/t/p/w1280/ibubeKZuo4ZI2Zu2Dm2s0gmMvuk.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "1h 53min",
                    Lancamento = new DateTime(2014, 6, 6)
                },
                new Filme
                {
                    Id = 46,
                    Nome = "Diário de uma Paixão",
                    Sinopse = "Em um asilo, um homem lê diariamente para uma mulher a história de Noah e Allie, jovens de classes sociais diferentes que se apaixonam na década de 1940. Apesar das adversidades e da oposição familiar, seu amor perdura ao longo dos anos, enfrentando separações e desafios até se reencontrarem.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 53,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/rNzQyW4f8B8cQeg7Dgj3n6eT5k9.jpg",
                    Genero = "Romance",
                    Avaliacao = 5,
                    Duracao = "2h 3min",
                    Lancamento = new DateTime(2004, 6, 25)
                },
                new Filme
                {
                    Id = 47,
                    Nome = "Titanic",
                    Sinopse = "Em 1912, a jovem aristocrata Rose embarca no luxuoso navio Titanic e conhece Jack, um artista pobre. Eles vivem um intenso romance a bordo, desafiando as convenções sociais, até que a tragédia do naufrágio muda suas vidas para sempre.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 89,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg",
                    Genero = "Romance",
                    Avaliacao = 5,
                    Duracao = "3h 14min",
                    Lancamento = new DateTime(1997, 12, 19)
                },
                new Filme
                {
                    Id = 48,
                    Nome = "Como Eu Era Antes de Você",
                    Sinopse = "Louisa Clark é contratada para cuidar de Will Traynor, um jovem rico que ficou tetraplégico após um acidente. Com personalidades opostas, eles desenvolvem uma relação que transforma suas vidas, enfrentando dilemas sobre amor e escolhas difíceis.",
                    AvaliacaoImdb = 71,
                    AvaliacaoTomates = 54,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/Ia3dzj5LnCj1ZBdlVeJrbKJQxG.jpg",
                    Genero = "Romance",
                    Avaliacao = 4,
                    Duracao = "1h 50min",
                    Lancamento = new DateTime(2016, 6, 3)
                },
                new Filme
                {
                    Id = 49,
                    Nome = "O Poderoso Chefão",
                    Sinopse = "Um poderoso chefão do crime entrega o controle de seu império clandestino ao filho relutante. Uma história épica sobre lealdade, poder e a família mafiosa Corleone nos Estados Unidos da década de 1940.",
                    AvaliacaoImdb = 92,
                    AvaliacaoTomates = 97,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
                    Genero = "Drama",
                    Avaliacao = 5,
                    Duracao = "2h 55min",
                    Lancamento = new DateTime(1972, 3, 14)
                },
                new Filme
                {
                    Id = 50,
                    Nome = "Orgulho e Preconceito",
                    Sinopse = "Na Inglaterra do século XIX, Elizabeth Bennet enfrenta pressões sociais para se casar. Quando conhece o orgulhoso Sr. Darcy, surge uma relação marcada por mal-entendidos e sentimentos conflitantes, desafiando as convenções da época.",
                    AvaliacaoImdb = 78,
                    AvaliacaoTomates = 86,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/sGjIvtVvTlWnia2zfJfHz81pZ9Q.jpg",
                    Genero = "Romance",
                    Avaliacao = 5,
                    Duracao = "2h 9min",
                    Lancamento = new DateTime(2005, 11, 11)
                },
                new Filme
                {
                    Id = 51,
                    Nome = "O Silêncio dos Inocentes",
                    Sinopse = "A agente do FBI Clarice Starling busca a ajuda do brilhante, mas perigoso, Dr. Hannibal Lecter, um psiquiatra canibal encarcerado, para capturar outro serial killer conhecido como Buffalo Bill. À medida que Clarice mergulha na mente de Lecter, ela enfrenta seus próprios medos e traumas.",
                    AvaliacaoImdb = 86,
                    AvaliacaoTomates = 96,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/uS9m8OBk1A8eM9I042bx8XXpqAq.jpg",
                    Genero = "Suspense",
                    Avaliacao = 5,
                    Duracao = "1h 58min",
                    Lancamento = new DateTime(1991, 2, 14)
                },
                new Filme
                {
                    Id = 52,
                    Nome = "Seven: Os Sete Crimes Capitais",
                    Sinopse = "Dois detetives, um prestes a se aposentar e outro novato, investigam uma série de assassinatos brutais que seguem os sete pecados capitais. À medida que se aprofundam no caso, descobrem uma trama sombria e perturbadora.",
                    AvaliacaoImdb = 86,
                    AvaliacaoTomates = 81,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/191nKfP0ehp3uIvWqgPbFmI4lv9.jpg",
                    Genero = "Suspense",
                    Avaliacao = 5,
                    Duracao = "2h 7min",
                    Lancamento = new DateTime(1995, 9, 22)
                },
                new Filme
                {
                    Id = 53,
                    Nome = "Garota Exemplar",
                    Sinopse = "No dia do seu quinto aniversário de casamento, Amy desaparece misteriosamente. Sob pressão da polícia e da mídia, o marido Nick começa a apresentar um comportamento estranho, levantando suspeitas sobre seu envolvimento no desaparecimento.",
                    AvaliacaoImdb = 81,
                    AvaliacaoTomates = 87,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/ts996lKsxvjkO2yiYG0ht4qAicO.jpg",
                    Genero = "Suspense",
                    Avaliacao = 5,
                    Duracao = "2h 29min",
                    Lancamento = new DateTime(2014, 10, 3)
                },
                new Filme
                {
                    Id = 54,
                    Nome = "Ilha do Medo",
                    Sinopse = "Em 1954, os agentes federais Teddy Daniels e Chuck Aule investigam o desaparecimento de uma paciente no hospital psiquiátrico Ashecliffe, localizado em uma ilha remota. Conforme a investigação avança, Teddy confronta segredos obscuros e enfrenta seus próprios demônios.",
                    AvaliacaoImdb = 82,
                    AvaliacaoTomates = 68,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/nrmXQ0zcZUL8jFLrakWc90IR8z9.jpg",
                    Genero = "Suspense",
                    Avaliacao = 5,
                    Duracao = "2h 18min",
                    Lancamento = new DateTime(2010, 2, 19)
                },
                new Filme
                {
                    Id = 55,
                    Nome = "O Sexto Sentido",
                    Sinopse = "O psicólogo infantil Malcolm Crowe atende Cole Sear, um garoto que afirma ver espíritos de pessoas mortas. À medida que Malcolm tenta ajudar Cole, ambos enfrentam revelações que mudarão suas vidas para sempre.",
                    AvaliacaoImdb = 86,
                    AvaliacaoTomates = 86,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/vOyfUXNFSnaTk7Vk5AjpsKTUWsu.jpg",
                    Genero = "Suspense",
                    Avaliacao = 5,
                    Duracao = "1h 47min",
                    Lancamento = new DateTime(1999, 8, 6)
                },
                new Filme
                {
                    Id = 56,
                    Nome = "O Exorcista",
                    Sinopse = "Uma atriz percebe mudanÃ§as assustadoras no comportamento de sua filha de 12 anos. Desesperada, busca ajuda de um padre, que conclui que a garota estÃ¡ possuÃ­da por uma entidade demonÃ­aca. Um exorcista experiente Ã© chamado para enfrentar o mal que habita a menina.",
                    AvaliacaoImdb = 85,
                    AvaliacaoTomates = 83,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/4ucLGcXVVSVnsfkGtbLY4XAius8.jpg",
                    Genero = "Terror",
                    Avaliacao = 5,
                    Duracao = "2h 2min",
                    Lancamento = new DateTime(1973, 12, 26)
                },
                new Filme
                {
                    Id = 57,
                    Nome = "O Iluminado",
                    Sinopse = "Jack Torrance aceita o emprego de zelador de um hotel isolado nas montanhas durante o inverno. Ele se muda com a esposa e o filho, que possui habilidades psÃ­quicas. O isolamento e forÃ§as sobrenaturais levam Jack Ã  loucura, colocando sua famÃ­lia em perigo.",
                    AvaliacaoImdb = 84,
                    AvaliacaoTomates = 84,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/xazWoLealQwEgqZ89MLZklLZD3k.jpg",
                    Genero = "Terror",
                    Avaliacao = 5,
                    Duracao = "2h 26min",
                    Lancamento = new DateTime(1980, 5, 23)
                },
                new Filme
                {
                    Id = 58,
                    Nome = "Alien: O Oitavo Passageiro",
                    Sinopse = "A tripulaÃ§Ã£o da nave Nostromo responde a um chamado de socorro em um planeta distante. LÃ¡, eles encontram uma forma de vida alienÃ­gena que comeÃ§a a caÃ§Ã¡-los um a um dentro da nave, transformando a missÃ£o em uma luta desesperada pela sobrevivÃªncia.",
                    AvaliacaoImdb = 85,
                    AvaliacaoTomates = 98,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg",
                    Genero = "Terror",
                    Avaliacao = 5,
                    Duracao = "1h 57min",
                    Lancamento = new DateTime(1979, 5, 25)
                },
                new Filme
                {
                    Id = 59,
                    Nome = "Invocação    do Mal",
                    Sinopse = "Baseado em eventos reais, o filme acompanha os investigadores paranormais Ed e Lorraine Warren, que ajudam uma famÃ­lia aterrorizada por uma presenÃ§a sombria em sua casa de campo. Eles enfrentam uma entidade demonÃ­aca poderosa que desafia suas habilidades.",
                    AvaliacaoImdb = 75,
                    AvaliacaoTomates = 86,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/wVYREutTvI2tmxr6ujrHT704wGF.jpg",
                    Genero = "Terror",
                    Avaliacao = 5,
                    Duracao = "1h 52min",
                    Lancamento = new DateTime(2013, 7, 19)
                },
                new Filme
                {
                    Id = 60,
                    Nome = "Hereditário",
                    Sinopse = "ApÃ³s a morte da matriarca da famÃ­lia Graham, sua filha Annie e seus entes queridos comeÃ§am a desvendar segredos sombrios sobre sua ascendÃªncia. Eventos sobrenaturais e tragÃ©dias se intensificam, levando a famÃ­lia a um destino aterrorizante e inevitÃ¡vel.",
                    AvaliacaoImdb = 73,
                    AvaliacaoTomates = 89,
                    Foto = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lHV8HHlhwNup2VbpiACtlKzaGIQ.jpg",
                    Genero = "Terror",
                    Avaliacao = 5,
                    Duracao = "2h 7min",
                    Lancamento = new DateTime(2018, 6, 8)
                },
                new Filme
                {
                    Id = 61,
                    Nome = "Passageiros",
                    Sinopse = "Uma nave espacial viajando para uma colônia em um distante planeta e transportando milhares de pessoas tem um mau funcionamento em suas câmaras do sono. Como resultado, dois passageiros são despertados 90 anos antes..",
                    AvaliacaoImdb = 70,
                    AvaliacaoTomates = 30,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/4ttmnglFa2WxDK3yBkMX1VlpkTo.jpg",
                    Genero = "Romance",
                    Avaliacao = 4,
                    Duracao = "1h 56min",
                    Lancamento = new DateTime(2007, 1, 5)
                }
            );
        }
    }
}
