<template>
  <div>
      <div class="section-5">
          <div class="container">
              <div class="row">
                  <div class="col-md-12 text-center mb-5">
                      <div class="inner-head">
                          <h3>Gợi Ý Hôm Nay</h3>
                          <hr>
                      </div>
                  </div>
              </div>
              <div class="row">
                  <div class="col-xl-2 col-lg-3 col-md-4" v-for="product in visibleProducts" :key="product.id" @click="NextIntroSpham(product)">
                      <div class="inner-product">
                          <div class="inner-discount">{{ product.discount }}%</div>
                          <div class="inner-img">
                              <img :src="product.wooden" alt="Product Image">
                          </div>
                          <div class="inner-desc">
                              <p>{{ product.name }}</p>
                          </div>
                          <div class="inner-price">
                              <p>₫ {{ product.price }}</p>
                              <span>Đã Bán: {{ formatSoldCount(product) }}</span>
                          </div>
                      </div>
                  </div>
              </div>
              <div class="row justify-content-center mt-30">
                  <div class="button" @click="loadMore">Xem Thêm</div>
              </div>
          </div>
      </div>
  </div>
</template>

<script>
import axios from 'axios'; 

export default {
  data() {
    return {
      products: [],
      pageSize: 18,
      loadedProducts: 0
    };
  },
  computed: {
    visibleProducts() {
      return this.products.slice(0, this.loadedProducts);
    },
  },
  mounted() {
    this.fetchData();
  },
  methods: {
    async fetchData() {
      try {
        const response = await axios.get('https://655ea5f6879575426b43ba2b.mockapi.io/DoNoiThat');
        this.products = response.data;
        this.loadMore();
      } catch (error) {
        console.error('Error:', error);
      }
    },
    loadMore() {
      this.loadedProducts += this.pageSize;
    },
    formatSoldCount(product) {
      return ((product.num * 0.000001).toFixed());
    },
    NextIntroSpham(product) {
      this.$store.commit('setProduct', product);
      this.$router.push({ name: 'intro', params: { id: product.id } });
      console.log(product.id);
    },
  }
};
</script>