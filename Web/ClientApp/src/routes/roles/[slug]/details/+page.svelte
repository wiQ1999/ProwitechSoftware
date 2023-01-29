<script>
    import formNameStore from "$lib/stores/GlobalStore.js";
    import { onMount } from "svelte";
    import { page } from "$app/stores";
    import { getRoleById, putRole } from "$lib/stores/Roles";
    import BaseEditableForm from "$lib/components/base/BaseEditableForm.svelte";

    let baseRole = {};
    let role = {};
    let isEditing = false;

    onMount(async () => {
        baseRole = await getRoleById($page.params.slug);
        role = { ...baseRole };

        formNameStore.update(() => role.name ?? "");
    });

    async function onSubmitHandler() {
        if (checkIfRoleChanged()) {
            await putRole($page.params.slug, role);
            baseRole = { ...role };
        }

        isEditing = false;
    }

    function checkIfRoleChanged() {
        return !(role.id === baseRole.id && role.name === baseRole.name);
    }

    function onEditingStopHandler() {
        role = { ...baseRole };
    }
</script>

<BaseEditableForm
    bind:isEditing
    formName="Szczegóły roli"
    {onEditingStopHandler}
    {onSubmitHandler}
>
    <label for="role.name" class="block">Nazwa</label>
    <input
        type="text"
        bind:value={role.name}
        disabled={!isEditing}
        required
        class="text-base h-auto mb-8 outline-0 p-[15px] w-[100%] bg-[#e8eeef] border-2 focus:border-[#0078c8] disabled:text-[#8a97a9]"
    />
</BaseEditableForm>
