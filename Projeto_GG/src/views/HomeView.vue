    
<template style="">
  <main style="margin-bottom: 280px; background-color:#181818;">
  <link rel="stylesheet" type="text/css" href="/src/home.css" media="screen" />
  <nav class="navbar navbar-expand-lg bg-body-" style="justify-content: center; align-items: center; background-color: rgba(37,37,37); border: rgba(37,37,37); color: white">
    <div class="container-fluid" style="justify-content: center; align-items: center; background-color: rgba(37,37,37)">
      <img src="/logo.png" style="width: 90px; margin: 16px;">
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent" style="background-color: rgba(37,37,37);">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="/home" style="color: white;">Página Inicial</a>
        </li>
        <li class="nav-item">
          
          <router-link class="nav-link" to="/about" style="color: gray;">Histórico de Pedidos</router-link>
        </li>
        <!-- <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Histórico de Pedidos
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li> -->
      </ul>
      <form class="d-flex" role="search" style="color: white; align-items: center;">
        <input class="form-control me-2" type="search" placeholder="" aria-label="Search" style="background-color: rgba(30,30,30); border: none; color: white;">
        <button style="border: none; background-color: rgb(240, 36, 36); padding: 6px; color: white; font-weight: 500; border-radius: 4px; box-shadow: 2px 2px 1px rgb(150, 36, 36);">Buscar</button>
      </form>
      <div style="display: flex; padding: 10px;align-items: center; justify-content: space-between; flex-direction: row;">
        <img src="/dog.jpg" style="width: 48px; border-radius: 48px; margin: 10px;">
      </div>
      <router-link class="nav-link" to="/">Sair</router-link>
    </div>
  </div>
  </nav>
  <h1 style="margin-left:56px; margin-top: 24px; margin-bottom: -24px; font-weight: 900; color: white; font-size: 2em;">Bem vindo(a), <a style="font-size: 1em; color: rgb(240, 36, 36)">Gabriela!</a></h1>
  <p style="margin-left:56px; margin-top: 28px; margin-bottom: -24px; font-weight: 500; color: gray ">Confira as novidades da sua conta!</p>
  <div class="row" style="padding: 50px;">
  <div class="col-sm-3 mb-3 mb-sm-0">
    <div class="card" style="border-radius: 24px; border: none;">
      <div class="card-body" style="height: 100px; border: none; box-shadow: 2px 2px 12px rgba(0, 0, 0, 0.137); background-color: rgba(37,37,37); border-radius: 8px; color: white;">
        <h5 class="card-title" style="color: grey; font-size: 16px; color: white">Meta de entregas</h5>
        <div class="icones" style="display: flex; flex-direction: row; align-items: center; justify-content: space-between; margin-top: 20px;">
          <div class="progress" role="progressbar" aria-label="Example with label" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100" style="width: 250px;">
        <div class="progress-bar" style="width: 55%; background-color: rgb(200, 36, 36); color: white; font-weight: 600;" >55%</div>
      </div>
          <img src="/src/icons/monitoring_24dp_FILL0_wght300_GRAD0_opsz24.png" style="width: 32px; background-color: rgb(255, 36, 36, 0.130); border-radius: 4px;border: solid   rgb(255, 36, 36, 0.00); ">
        </div>
      </div>
    </div>
  </div>
  <div class="col-sm-3">
    <div class="card" style="border-radius: 24px; border: none;">
      <div class="card-body" style="height: 100px; border: none; box-shadow: 2px 2px 12px rgba(0, 0, 0, 0.137); background-color: rgba(37,37,37); border-radius: 8px; color: white;">
        <h5 class="card-title" style="color: white; font-size: 16px;">Entregas realizadas</h5>
        <div class="icones" style="display: flex; flex-direction: row; align-items: center; justify-content: space-between;">
          <p class="card-text" style="color:  rgb(240, 36, 36); font-size: 28px; font-weight: bold;">240</p>
          <img src="/src/icons/inventory_2_24dp_FILL0_wght300_GRAD0_opsz24.png" style="width: 32px; background-color: rgb(255, 36, 36, 0.130); border-radius: 4px; border: solid   rgb(255, 36, 36, 0.00); ">
        </div>
       
      </div>
    </div>
  </div>
  <div class="col-sm-3">
    <div class="card" style="border-radius: 24px; border: none;">
      <div class="card-body" style="height: 100px; border: none; box-shadow: 2px 2px 12px rgba(0, 0, 0, 0.137); background-color: rgba(37,37,37); border-radius: 8px; color: white;">
        <h5 class="card-title" style="color: white; font-size: 16px;">Avaliações</h5>
        <div class="icones" style="display: flex; flex-direction: row; align-items: center; justify-content: space-between;">
          <p class="card-text" style="color:  rgb(240, 36, 36); font-size: 28px; font-weight: bold;">546</p>
          <img src="/src/icons/verified_24dp_FILL0_wght300_GRAD0_opsz24.png" style="width: 32px;  background-color: rgb(255, 36, 36, 0.130); border-radius: 4px; border: solid   rgb(255, 36, 36, 0.00); ">
        </div>
       
      </div>
    </div>
  </div>
  <div class="col-sm-3">
    <div class="card" style="border-radius: 24px; border: none;">
      <div class="card-body" style="height: 100px; border: none; box-shadow: 2px 2px 12px rgba(0, 0, 0, 0.137); background-color: rgba(37,37,37); border-radius: 8px; color: white;">
        <h5 class="card-title" style="color: white; font-size: 16px;">Multas recebidas</h5>
        <div class="icones" style="display: flex; flex-direction: row; align-items: center; justify-content: space-between;">
          <p class="card-text" style="color:  rgb(240, 36, 36); font-size: 28px; font-weight: bold;">0</p>
          <img src="/src/icons/thumb_down_24dp_FILL0_wght300_GRAD0_opsz24 (1).png" style="width: 32px;  background-color: rgb(255, 36, 36, 0.130); border-radius: 4px; border: solid   rgb(255, 36, 36, 0.00); ">
        </div>
       
      </div>
    </div>
  </div>
  </div>
  <h1 style="text-align: left;  font-weight: 900;  margin-left: 50px; color: white">
    Seus Dados
  </h1>
  <p style="text-align: left; font-weight: 500; color: gray ;margin-left: 50px">Confira os seus dados pessoais e progressos</p>
  <div style="margin-left: 50px;">
  <div class="donut-chart-block block" style=""> 
    <h2 class="titular" style="font-weight: 800">SOBRE AS SUAS ENTREGAS</h2>
    <div class="donut-chart">
    <div id="porcion1" class="recorte"><div class="quesito ios" data-rel="21"></div></div>
    <div id="porcion2" class="recorte"><div class="quesito mac" data-rel="39"></div></div>
    <div id="porcion3" class="recorte"><div class="quesito win" data-rel="31"></div></div>
    <div id="porcionFin" class="recorte"><div class="quesito linux" data-rel="9"></div></div>
    </div>
    <ul class="os-percentages horizontal-list">
    <li>
    <p class="ios os scnd-font-color" style="font-size: 12px">Canceladas</p>
    <p class="os-percentage">21<sup>%</sup></p>
    </li>
    <li>
    <p class="mac os scnd-font-color" style="font-size: 12px">Leves</p>
    <p class="os-percentage">39<sup>%</sup></p>
    </li>
    <li>
    <p class="linux os scnd-font-color" style="font-size: 12px">Pesadas</p>
    <p class="os-percentage">9<sup>%</sup></p>
    </li>
    <li>
    <p class="win os scnd-font-color" style="font-size: 12px">Concluídas</p>
    <p class="os-percentage">31<sup>%</sup></p>
    </li>
    </ul>
    </div>
    <div class="line-block block" style="">
      <div class="line-chart" style="background-color: rgba(0, 0, 0, 0.137); color: black;">
        <div class='grafico' style="color: white;">
       <ul class='eje-y'>
         <li data-ejeY='30'></li>
         <li data-ejeY='20'></li>
         <li data-ejeY='10'></li>
         <li data-ejeY='0'></li>
       </ul>
       <ul class='eje-x'>
         <li>Abr</li>
         <li>Mai</li>
         <li>Jun</li>
       </ul>
         <span data-valor='25'>
           <span data-valor='8'>
             <span data-valor='13'>
               <span data-valor='5'>   
                 <span data-valor='23'>   
                 <span data-valor='12'>
                     <span data-valor='15'>
                     </span></span></span></span></span></span></span>
       </div>

     </div>
                    <ul class="time-lenght horizontal-list">
                        <li><a class="time-lenght-btn" href="#14">Semana</a></li>
                        <li><a class="time-lenght-btn" href="#15">Mês</a></li>
                        <li><a class="time-lenght-btn" href="#16">Ano</a></li>
                    </ul>
                    <ul class="month-data clear">
                        <li>
                            <p>ABR<span class="scnd-font-color"> 2024</span></p>
                            <p><span class="entypo-plus increment"> </span>21<sup>%</sup></p>
                        </li>
                        <li>
                            <p>MAI<span class="scnd-font-color"> 2024</span></p>
                            <p><span class="entypo-plus increment"> </span>48<sup>%</sup></p>
                        </li>
                        <li>
                            <p>JUN<span class="scnd-font-color"> 2024</span></p>
                            <p><span class="entypo-plus increment"> </span>35<sup>%</sup></p>
                        </li>
                    </ul>
                </div>
              </div>
            <h1 style="font-weight: 900; margin-bottom: -8px">Confira seu histórico de pedidos</h1>
            <div class="tabela" style="display: flex;  padding: 0px;">
              <table class="table table-dark table-hover" style="padding: 0px; margin-top:24px ; margin-right: 0px; width: 100%; color: white; ">
                <thead style="padding: 0px; background-color: rgba(15,15,15);">
                  <tr>
                    <th scope="col">ID</th>
                    <th scope="col">Título</th>
                    <th scope="col">Endereço</th>
                    <th scope="col">Horário</th>
                    <th scope="col">Data</th>
                    <th scope="col">Ação</th>
                  </tr>
    </thead>
    <tbody >
      <tr v-for="(pedido, index) in pedidos" :key="index" >
        <td>{{ pedido.id }}</td>
        <td>{{ pedido.titulo }}</td>
        <td>{{ pedido.endereco }}</td>
        <td>{{ pedido.horario }}</td>
        <td>{{ pedido.data }}</td>
      </tr>
     <tr style="background-color: rgba(30,30,30);">
        <th scope="row">1</th>
        <td>Mesa de madeira</td>
        <td>Rua Cachorro Feliz, 450</td>
        <td>15h00</td>
        <td>22/04/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>
        <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <h1 class="modal-title fs-5" id="staticBackdropLabel">Confirmação de entrega</h1>
              <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
              Deseja confirmar essa entrega?
            </div>
            <div class="modal-footer">
              <button type="button" class="btn" data-bs-dismiss="modal" style="background-color: rgb(240, 36, 36); color: white">Cancelar</button>
              <button type="button" class="btn" data-bs-dismiss="modal" style="background-color: rgb(15, 15, 15); color: white">Confirmar entrega</button>
            </div>
          </div>
        </div>
      </div>
      </tr>
      <tr>
        <th scope="row">2</th>
        <td>Mudança Gigante</td>
        <td>Rua Nova Marília, 387</td>
        <td>11h00</td>
        <td>05/06/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>


      </tr> 


      <!-- COMPONENTE CONECTADO A API -->

      


      <!-- <tr>
        <th scope="row">3</th>
        <td>Espelho Grande</td>
        <td>Rodovia Presidente Prudente, 50</td>
        <td>13h40</td>
        <td>14/12/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>

      </tr>
      <tr>
        <th scope="row">4</th>
        <td>Mesa de Madeira Grande</td>
        <td>Bairro Marcia Guimarães, 150</td>
        <td>11h40</td>
        <td>15/12/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>

      </tr>
      <tr>
        <th scope="row">5</th>
        <td>Computador Gamer</td>
        <td>Rua Professor Unimar, 560</td>
        <td>20h40</td>
        <td>18/12/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>

      </tr>
      <tr>
        <th scope="row">6</th>
        <td>Espelho Grande</td>
        <td>Avenida Presidente Prudente, 50</td>
        <td>13h40</td>
        <td>14/12/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>

      </tr>
      <tr>
        <th scope="row">7</th>
        <td>Espelho Grande</td>
        <td>Rua Presidente Prudente, 50</td>
        <td>13h40</td>
        <td>14/12/2024</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td> -->
        
        <!-- </tr> -->
      </tbody>
    </table>
  </div>
  
  <div class="col-md-8" >

        <h2 style="color: white; font-weight: 800;">Sobre você</h2>
        <div class="horizontal-chart">
          <div class="bar" style="width: 100%; background-color: rgb(230, 36, 36); text-align: center;">Entregas Concluídas</div>
          <div class="bar" style="width: 80%; background-color: rgb(190, 36, 36); text-align: center;">Avaliações Positivas</div>
          <div class="bar" style="width: 60%; background-color: rgb(160, 36, 36); text-align: center;">Entregas Pendentes</div>
          <div class="bar" style="width: 50%; background-color: rgb(130, 36, 36); text-align: center;">Metas Concluídas</div>
          <div class="bar" style="width: 25%; background-color: rgb(100, 36, 36); ">Atrasos</div>
        </div>
      </div>
</main>
</template>

<style>
  .horizontal-chart-container {
    width: 100%;
    padding: 20px;
    background-color: #181818;
    border-radius: 8px;
    box-shadow: #181818;
  }
  .horizontal-chart {
    display: flex;
    flex-direction: column;
    gap: 10px;
  }
  .horizontal-chart .bar {
    height: 30px;
    line-height: 30px;
    color: white;
    text-align: right;
    padding-right: 10px;
    border-radius: 5px;
  }

</style>

<script>
// import {onMounted, reactive, ref} from 'vue';
// import Tabela from '../components/Tabela.vue';

// let tab = reactive(ref())

// onMounted(()=> {
//   fetch("")
//   .then(response => response.json())
//   .then(response => {
//     tab.value = response.results
//     console.log(tab)
//   });
// })

import PedidoDataService from "../services/PedidoDataService";


export default {
  name: "list-pedidos",
  data() {
    return{
      pedidos: []
    };
  },
  methods: {
    retrivePedido() {
      PedidoDataService.getAll()
      .then(response => {
        this.pedidos = response.data;
        console.log(this.pedidos);
      })
      .catch(e => {
        console.log(e)
      });
    }
  },
  mounted() {
    this.retrivePedido();
  },
}


</script>