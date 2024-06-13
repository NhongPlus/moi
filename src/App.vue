<template>
  <nav>
    <nav-bar v-if="showNavBar" />
    <router-view />
    <global-footer v-if="showFooter"/>
  </nav> 
</template>

<script>
import GlobalFooter from './components/GlobalFooter.vue';
import NavBar from './components/NavBar.vue';

export default {
  name: 'App',
  components: { 
    GlobalFooter,
    NavBar
  },
  data() {
    return {
      // Xác định xem có nên hiển thị NavBar hay không
      showNavBar: false,
      showFooter: false,
    };
  },
  methods : {

  },
  mounted() {
    // Kiểm tra path của router để xác định trang và hiển thị NavBar theo điều kiện
    this.showNavBar = this.$route.path === '/' || this.$route.path === '/about' || this.$route.path === '/cart';
    this.showFooter = this.$route.path === '/' || this.$route.path === '/about' || this.$route.path === '/cart';
  },
  watch: {
    // Theo dõi thay đổi của route để cập nhật hiển thị của NavBar
    '$route'(to) {
      this.showNavBar = to.path === '/' || to.path === '/about' || to.path === '/cart';
      this.showFooter = to.path === '/' || to.path === '/about' || to.path === '/cart';
    }
  }
}
</script>
