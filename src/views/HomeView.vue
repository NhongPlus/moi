<template>
  <div class="home">
    <back-ground />
    <categrories-list />
    <list-product />
  </div>
</template>

<script>
import BackGround from '@/components/BackGround.vue';
import CategroriesList from '../components/CategoriesList.vue';
import ListProduct from '@/components/ListProduct.vue';

export default {
  name: 'HomeView',
  components: {
    BackGround,
    CategroriesList,
    ListProduct,

  }
}
</script>
