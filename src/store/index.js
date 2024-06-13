import { createStore } from 'vuex'
export default createStore({
  state: {
    selectedProduct: null
  },
  mutations: {
    setProduct(state, product) {
      state.selectedProduct = product;
    }
  },
  getters: {

  },
  actions: {

  },
  modules: {
    
  }
})
