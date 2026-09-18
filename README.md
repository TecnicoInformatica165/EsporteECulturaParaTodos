# Esporte & Cultura para Todos - Especificacao de MVP

## 1. Problema e Solucao (Visao Geral)
* **Problema:** Falta de acesso a atividades esportivas e culturais para pessoas em vulnarebilidade social.
* **Publico-alvo:** Além de moradores de comunidade: crianças, adolescentes e idosos.
* **Escopo do MV:** Cadastro de pessoas, seleção de modalidade esportiva ou cultural, direcionar os usuários as opções de modalidades disponíveis.

## 2. Requisitos Funcionais (RF)
* **RF01:** O site deverá permitir que o usuário realize seu cadastro, com dados básicos (nome, contato e data de nascimento para cálculo da faixa etária).

* **RF02:** O sistema deverá disponibilizar recursos que facilitem a navegação por pessoas com diferentes necessidades de acessibilidade.

* **RF03:** cada atividade deve possuir uma quantidade maxima de participantes definida pelo responsavel do projeto.

* **RF04:** O sistema deve informar a quantidade de vagas disponíveis.

* **RF05:** O sistema deverá permitir que instituições parceiras cadastrem atividades.


## 3. Regras de Negocio (RN)
* **RN01 (Vinculada ao RF01):** O cadastro deve solicitar as informações pessoais necessárias para identificar o usuário e direcionar adequadamente as atividades disponíveis.

* **RN02 (Vinculada ao RF02):** Limitar para que o sistema consiga identificar a faixa etária do usuário encaminhando ele para uma vaga que condiz com as informações.

* **RN03 (Vinculada ao RF03):** O sistema deverá permitir que o usuário filtre as atividades por categoria, faixa etária, localização e disponibilidade de vagas, exibindo apenas as opções que correspondam aos filtros selecionados.

* **RN04 (Vinculada ao RF04):** O sistema deverá enviar notificações ao usuário sobre novas atividades, alterações de horários, cancelamentos e atualizações relacionadas às suas inscrições.

* **RN05 (Vinculada ao RF05):** O sistema deverá permitir que instituições parceiras realizem um cadastro, fornecendo informações como nome da instituição, endereço, telefone, responsável e atividades oferecidas.

* **RN06 (Vinculada ao RF06):** O sistema não deve permitir que uma pessoa se inscreva em uma atividade aonde não tenha vagas disponíveis.

## 4. Cenarios de Teste (Formato Dado-Quando-Entao / BDD)
*Estes cenarios serao convertidos diretamente em codigo de teste (TDD).*

* **Cenario 1 (Fluxo Principal - RN06):**
    * **Dado** que o usuário está  cadastrado corretamente e quer escolher uma atividade esportiva ou cultural.
    * **E** a atividade tem 10 vagas disponiveis e bate com a descrição do usuário,
    * **Quando** ele confirmar a inscrição,
    * **Entao** o sistema deve registrar aquela pessoa como participante da atividade. A quantidade de vagas passa de 10 para 9.

* **Cenario 2 (Fluxo de Excecao - RN06):**
    * **Dado** que o usuário está  cadastrado corretamente e quer escolher uma atividade esportiva ou cultural.
    * **E** a atividade nao tem mais vagas disponiveis,
    * **Quando** ela nao consegue a inscrição,
    * **Entao** o sistema deverá informar que os campos que precisam ser preenchidos e impedir o cadastro.

* **Cenario 1 (Fluxo Principal - RN01):**
    * **Dado** que o usário está na tela de cadastro.
    * **E** possui todas as informações pessoais e necessárias,
    * **Quando** preencher os campos obrigátorios e finalizar cadastro.
    * **Entao** o sistema deve cadastrar a pessoa e direciona-la para as atividades disponíveis.

* **Cenario 2 (Fluxo Exeção - RN01):**
  * **Dado** que o usário está na tela de cadastro.
  * **E** não preenche ou nao possui todas as informações pessoais e necessárias,
  * **Quando** não consegue preencher os campos e finalizar o cadastro.
  * **Entao** o sistema deve

* **Cenario 1 (Fluxo Principal - RN02):**
  * **Dado** que o usuário esárealizando o cadastro.
  * **E** informa a idade corretamente,
  * **Quando** finaliza o cadastro,
  * **Entao** o sistema deverá identificar sua faixa etária e apresentar atividades compatíveis.

**Cenario 2 (Fluxo Exeção RN02):**
  * **Dado** que o usuário esárealizando o cadastro.
  * **E** informa uma idade inválida ou incompatível com o formato solicitado,
  * **Quando** tentar finalizar o cadastro,
  * **Entao** o sistema deverá informar que a idade é inválida e solicitar a correção.

* **Cenario 1 (Fluxo Principal - RN03):**
  * **Dado** que existem atividades cadastradas,
  * **E** o usuário está na tela de atividades,
  * **Quando** selecionar um ou mais filtros,
  * **Entao** o sistema deverá apresentar apenas as atividades que correspondem aos filtros.

* **Cenario 2 (Fluxo Exeção - RN03):**
  * **Dado** que existem atividades cadastradas,
  * **E** nãp existem atividades que correspondem aos filtros escolhidos,
  * **Quando** realiza busca,
  * **Entao** o sistema deverá informar que nenhuma atividade foi encontrada.

* **Cenario 1 (Fluxo Principal - RN04):**
  * **Dado** que o usuário está escrito em uma atividade,
  * **E** as notificações ativadas,
  * **Quando** Houver alteração no horário ou cancelamento da atividade,
  * **Entao** o sistema deverá enviar uma notificação ao usuário.

* **Cenario 2 (Fluxo Exeção - RN04):**
  * **Dado** que o usuário está escrito em uma atividade,
  * **E** as notificações ativadas e houve uma alteração nas atividades,
  * **Quando** o sistema tentar enviar a notificação e houver uma falha no envio,
  * **Entao** o sistema deverá registrar a falha e tentar realizar o envio novamente.

* **Cenario 1 (Fluxo Principal - RN05):**
  * **Dado** que uma instituição deseja se cadastrar,
  * **E** possui todas as informações necessárias,
  * **Quando** preencher corretamente os campos obrigatórios,
  * **Entao** o sistema deverá concluir o cadastro da instituição.

* **Cenario 2 (Fluxo Exeção - RN05):**
  * **Dado** que uma instituição está realizando cadastro,
  * **E** existem informações obrigatórias não preenchidas,
  * **Quando** tentar finalizar o cadastro,
  * **Entao** o sistema deverá informar os campos pendentes e impedir o cadastro.
