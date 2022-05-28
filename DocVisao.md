Documento de visão

## Stack Learn

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/05/2022 | **1.00** | Versão Inicial  | Infoweb 3 |

## 1. Objetivo do Projeto 
Este projeto tem objetivo de desenvolver um site voltado para venda de cursos online da empresa Stack, assim como visualização dos conteúdos das aulas, e interação com os seus respectivos professores.
 
## 2. Descrição do problema 

| | |
|:-|:-|
| **_O problema_**    | A empresa Stack, diante da digitalização dos serviços em geral, vê a necessidade de implementar a modalidade de cursos online, uma vez que apenas ofertam cursos presenciais.  |
| **_afetando_**      | O alcance de vendas da empresa e satisfação dos alunos.                      |
| **_cujo impacto é_**| expansão da empresa e a possibilidade de um estudo mais flexibilizado para cada aluno.                                    |
| **_uma boa solução seria_** | Distribuição dos cursos via internet e gerenciamento dos conteúdos e do processo de aprendizagem.  |
| | |

## 3. Descrição dos usuários

| Nome | Descrição | Responsabilidades |
|:- |:- |:- |
| Administrador  | Gestor da plataforma; Usuário responsável pelo monitoramento dos processos que irão permitir que os clientes/alunos adquiram os cursos e que os professores possam disponibilizar os seus materiais. | Cadastrar e fazer a moderação dos cursos que poderão entrar na plataforma futuramente, de forma a perceber se ferem as diretrizes da plataforma; Disponibilizar ou bloquear a apresentação do curso na plataforma; Registrar informação de controle de pagamento de pedidos; Cadastrar, e excluir se for necessário, alunos e professores. |
| Usuário | Usuário que visualiza o site; O usuário deve ter a possibilidade de obter informações acerca dos cursos, preços, avaliações dos alunos que já adquiriram o curso e informações do(s) professor(es) sem a necessidade de registrar suas informações cadastrais no site. | O usuário poderá pesquisar os cursos por nome ou filtrar por preço, áreas (ENEM, tecnologia, vestibulares) e os assuntos dentro delas (biologia para ENEM, arquitetura de software , professor, etc); Será possível também montar um carrinho de compras com os cursos desejados, caso não obtenha nenhum plano (porém não será permitido comprar, pois necessita-se um conta no site para efetuar uma compra);  Deverá ser capaz de visualizar os planos e suas principais informações, entre mensal, anual e vitalício; Caso deseje, poderá se registrar como aluno ou professor, através de um cadastro específico para cada um. |
| Cliente/Aluno | Usuário cadastrado como estudante; O usuário, após realizar seu cadastro no site, poderá realizar compras e estudar. | Após a inclusão de dados cadastrais tais como login e senha, o usuário passa a ser visto como cliente e poderá registrar seus pedidos. Os pedidos poderão ser compostos por um ou mais cursos. O valor total do pedido deve ser apresentado. O cliente deve ter acesso às seguintes funcionalidades no site: Alterar seus dados cadastrais; Visualizar seu histórico e progresso nos cursos; Cancelar a compra do curso e pedir reembolso; Avaliar as aulas e tirar dúvidas nos comentários das vídeo-aulas para os professores responderem.|
| Professor | Usuário cadastrado como docente; O usuário realizará o cadastro de autorização e também servirá de assistente para as dúvidas dos acadêmicos. | Em primeira via, para ser considerado um professor oficial da Stack Learn, deverá apresentar dados cadastrais como: nome completo, endereço, formação (onde estudou, onde trabalhou), além da proposta do curso, pois para ser professor tem que ter pelo menos um curso cadastrado; Já em cadastros cotidianos apenas o login e senha serão pedidos; Poderá visualizar e responder as dúvidas. |
 
## 4. Descrição do ambiente dos usuários
 
O comércio eletrônico tem três tipos de usuários. O tipo administrador representa o gestor da loja e seus colaboradores, o tipo cliente que representa o cliente, seja ele anônimo ou já cadastrado e o Professor o qual deve estar aprovado e cadastrado pelo administrador. 

O administrador acessará o site e fará a configuração dos produtos a serem vendidos, realizará o cadastro dos filiados e terá o controle sobre as vendas e comentários da plataforma. 

O usuário cliente acessará o site utilizando um computador ou celular e visualizará os cursos vendidos na loja, assim como assinaturas disponíveis, podendo realizar a compra, se desejar. Ademais, poderá visualizar os vídeos sem internet, existirão poucas restrições quanto ao ambiente, sendo apenas necessário o uso da internet e o login para efetuar a compra.

O Professor terá sua conta anterior de Aluno/Cliente e, após a apresentação do seu curso ou projeto aos administradores, caso aprovado, terá acesso ao ambiente virtual do filiado. Desse modo observará os comentários em relação aos projetos, assim podendo tirar dúvidas e insatisfações e ver sua classificação dentro da plataforma.

## 5. Principais necessidades dos usuários

Considerando o ponto de vista do lojista e administrador do site, a sua necessidade é de um espaço virtual a fim de abarcar os desejos de uma grande porcentagem de estudantes atuais, assim como de aumentar as vendas e o lucro de sua empresa. Já com o professor, ele também deseja trabalhar lado a lado com a instituição, podendo abarcar uma grande quantidade de alunos, respondendo-os nos comentários das aulas e assim ganhar mais capital.

Considerando o ponto de vista do cliente, como um aluno, ele deseja ter acesso a um site com a maior variedade de escolhas possíveis, objetivando adquirir o conhecimento desejado de uma forma individualizada, em que ele poderá assistir às videoaulas no tempo que quiser e ao mesmo tempo ter chances de sanar suas dúvidas, caso apareçam, acerca do assunto e ver o progresso naquela matéria, além de obter esse serviço de modo rápido e fácil.

## 6. Alternativas concorrentes

Uma grande concorrente ao comércio eletrônico planejado é o Portal Educação, instituição voltada ao ensino da modalidade profissionalizante com cursos como administração e negócios; saúde; idiomas; tecnologia; marketing e design. O site dispõe de um carrinho de compras o qual pode-se adicionar diversos e sem necessidade de login para efetuar a compra, além de que todos os cursos clicados individualmente contém informações como: nível de dificuldade, o valor parcelado junto do total, carga horária, público alvo, se o curso é aprovado pelo MEC e 3 sessões de recomendações com “cursos vistos após este”, “quem cursou, gostou também" e “aproveite para completar seus estudos”. Além disso, assinaturas e cupons são ofertados, com planos de acesso total ou parcial dos conteúdos por um determinado preço, em que o estudante após entrar na seção "área do aluno”, permitido apenas com o login, poderá visualizar seu progresso. Diante disso, as dúvidas acerca do funcionamento da aplicação web estão dentro da opção “central de vendas”, nome nada pouco sugestivo para a sua real função, mas lá o usuário poderá abrir um chamado específico ou ver respostas de perguntas frequentes.

Outra alternativa é o Kultivi, o qual oferece cursos voltados à idioma, ENEM, concursos, OAB e dentre outros já na página inicial sem cadastro, de forma que cada opção é escolhida individual, sem um carrinho cheio de opções para finalizar a compra, uma vez que todos são disponibilizados de modo gratuito, o que facilita o consumo de vários usuários sem condições financeiras, sendo que um usuário sem registro não pode simplesmente começar a ver os vídeos do nada,pois, a fim de que o histórico e o progresso seja salvo, o cadastro é necessário. Além disso, não há barra de pesquisa e todos os cursos estão disponibilizados em uma única página com categorias clicáveis as quais abrem a página com os cursos dela, por exemplo, idiomas, concursos, enem. Já ao apertar em um curso específico, as principais informações que aparecem são: motivos para fazer o curso, tempo de duração, metodologia e quem é o professor(a).

Por fim, outra concorrente em potencial é a Alura, empresa voltada ao ensino de tecnologia, cuja aplicação web oferta mais um espaço de aprendizado do que um ambiente de mercado, com o setor oferecido ao usuário sem login apenas demonstrativo. Ainda na página inicial, esse usuário pode visualizar as diversas opções de cursos contidas nos tópicos como: programação, front-end, data science, devops e dentre outros. No entanto, não há seção de carrinhos e favoritar as opções, necessita-se a escolha de um dos planos para usufruir de todos os serviços, funcionando como uma matrícula em uma escola. Desse modo, mesmo sem a seção de carrinho e a obrigatoriedade de ser aluno para ver os cursos, a interface web é bem agradável, com a área de login possuindo uma opção de matrícula caso o usuário sem cadastro tenha clicado errado e deseja na verdade fazer parte dos alunos, além de informações importantes quando se escolhe um curso, possuindo: um resumo do que será aprendido, quantidade de horas, atividade, minutos de vídeos, alunos, se possui certificado de participação ou não, quem é o instrutor etc.

## 7.	Visão geral do produto

Esse projeto consiste em um site voltado para uma empresa de cursos online, com a venda de cursos em geral, voltados desde ENEM, idiomas, profissionalizantes, até vestibulares, possuindo um ambiente virtual acessível a todos os tipos de usuários e com intuito de facilitar cada vez mais o aprendizado das pessoas em diversas áreas.  Além disso, o usuário pode comprar um curso específico ou assinar um dos planos: mensal, anual ou vitalício, ou então não assinar nenhum dos dois e usufruir dos serviços individuais. Quanto ao processo pós-compra, o cliente vai poder tirar dúvidas com o(s) professor(es), além de poder avaliar os cursos com comentários e estrelas, repassando para os próximos compradores a satisfação que se foi obtida com o curso.
