import router from '@/router';
<template>
    <main style="align-items: center; justify-content: center; width: 300px; padding-left: 380px; padding-top: 140px;">  
      <link rel="stylesheet" type="text/css" href="/src/style.css" media="screen" />
    <ul class="background">
        <div class="img-forms">
            <form style="align-items: center; justify-content: center; padding: 48px;">
                <div class="mb-3" style="width: 400px;">
                    <h1 style="padding-bottom: 0px; font-weight: 700; color: white;">Cadastre-se!</h1>
                    <label for="exampleInputEmail1" class="form-label" style="color: white">Email</label>
                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" style="background-color: white;">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label" style="color: white">Senha</label>
                    <input type="password" class="form-control" id="exampleInputPassword1" style="background-color: white; ">
                </div>
                <router-link class="btn btn-primary" style="background-color:rgb(240, 36, 36); border: none; font-weight: 600; width: 100%;" to="/">Entrar</router-link>

                <router-link class="btn" style="background-color:none; border: none; font-weight: 400; margin-top: 12px;    width: 100%; text-align: center; justify-content: center; align-items: center; text-decoration: none; color: white;" to="/cad">Ainda não possue uma conta? <a style="color: rgb(240, 36, 36); font-weight: 800;">Cadastre-se</a></router-link>

            </form>
        </div>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
    </ul>
  </main>
</template>

<style>
    .img-forms{
        display:flex;
        align-items: center;
        justify-content: center;
        width: 300px; 
        padding-left: 50%; 
        padding-top: 10%;
    }
</style>