import router from '@/router';
<template>
    <main style="align-items: center; justify-content: center; width: 300px; padding-left: 380px; padding-top: 140px;">  
      <link rel="stylesheet" type="text/css" href="/src/style.css" media="screen" />
    <ul class="background">
        <div class="img-forms">
            <img src="/logo.png" style="width: 220px; height: 140px;">
            <form style="align-items: center; justify-content: center; padding: 48px;">
                <div class="mb-3" style="width: 400px;">
                    <h1 style="padding-bottom: 24px; font-weight: 700; color: white;">Seja bem-vindo!</h1>
                    <label for="exampleInputEmail1" class="form-label" style="color: white">Email</label>
                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" style="background-color: white;">
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label" style="color: white">Senha</label>
                    <input type="password" class="form-control" id="exampleInputPassword1" style="background-color: ehite; ">
                    <div id="emailHelp" class="form-text" style="color: lightgray; font-size: 10px; font-style: italic;">Insira uma senha que contenha pelo menos uma letra maiúscula, uma letra minúscula, um caractere especial e um número.</div>
                </div>
                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1" style="color: rgb(240, 36, 36);">
        
                    <label class="form-check-label" for="exampleCheck1" style="color: white">Lembre-se de mim</label>
                </div>
                <router-link class="btn btn-primary" style="background-color:rgb(240, 36, 36); border: none; font-weight: 600; width: 100%;" to="/home">Entrar</router-link>

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