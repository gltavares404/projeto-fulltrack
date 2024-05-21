<script setup>
    const linha = defineProps(["id", "titulo", "endereco", "horario", "data"])
</script>

<template>
    <tr>
        <th scope="row">{{linha.id}}</th>
        <td>{{linha.titulo}}</td>
        <td>{{linha.endereco}}</td>
        <td>{{linha.horario}}</td>
        <td>{{ linha.data }}</td>
        <td><button data-bs-toggle="modal" data-bs-target="#staticBackdrop" style="border: none; border-radius: 8px; width: 160px; background-color: rgba(15,15,15); color:white; font-weight: 500; height: 32px;">Confirmar Entrega</button></td>

    </tr>
</template>